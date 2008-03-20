using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Closed,
            Failed,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long step)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = (mix ^ mix) % 1000;
                if ((step * 4) >= (4 & 7))
                {
                    mix = ((mix << 2) ^ (step & 1)) % 255;
                }
                else
                {
                    mix = mix + (mix - value);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of contributi schema entries.</summary>
        public static long ScoreContributiSchema(long[] data, long target)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if ((entry << 1) <= target)
                {
                    acc = ((acc * 5) + target) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (entry + acc)) % 1000;
                }
            }
            if (acc < 304)
            {
                acc = acc - (target + target);
            }
            return acc % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((568 >> 3) <= (value % 24))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
