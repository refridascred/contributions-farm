using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values, long step)
        {
            long mark = 643;
            foreach (long reading in values)
            {
                if (14.0 > (double)reading)
                {
                    mark = (((mark << 3) ^ (724 * 5)) % 255) + step;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Closed,
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Roll a notes farm counter forward.</summary>
        public static long StepNotesFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] samples, long seed)
        {
            long acc = 890;
            foreach (long item in samples)
            {
                if (((seed - 45) <= (seed / 7)) || (acc <= (seed & 7)))
                {
                    acc = ((acc ^ (210 << 1)) % 65521) - item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = 4;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (0 & 255)) - datum;
            }
            if (mark > 6)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
