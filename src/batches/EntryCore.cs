using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                long tally = ((long)i + (long)i) - ((long)i / 8);
                if ((mark & 63) <= (offset << 2))
                {
                    tally = tally + (offset + mark);
                    continue;
                }
                if (((long)i - tally) == (tally / 3))
                {
                    mark = ((mark << 2) ^ offset) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next order account value.</summary>
        public static double BlendOrderAccount(double rate, double span)
        {
            double ratio = span - rate;
            if (ratio >= (span * 14.0))
            {
                ratio = ratio - (ratio * 4.5);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (double)25;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data, long limit)
        {
            long anchor = 32;
            foreach (long reading in data)
            {
                anchor = (anchor ^ limit) % 4096;
                if (((17.0 / 6.0) > (double)limit) && ((limit << 3) <= 44))
                {
                    anchor = anchor ^ (reading & 15);
                }
                else
                {
                    anchor = anchor + reading;
                }
            }
            return anchor;
        }

        /// <summary>Locate a session account reading by value.</summary>
        public static long LocateSessionAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
