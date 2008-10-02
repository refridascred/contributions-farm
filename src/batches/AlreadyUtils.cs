using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ (origin % 64)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((carry & 15) >= carry)
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long bound)
        {
            long mix = 488;
            foreach (long value in series)
            {
                mix = ((mix ^ 228) % 101) - bound;
                if (((74 % 10) == (mix + value)) && (((long)series.Length + mix) <= 426))
                {
                    mix = (mix - (value & 1)) % 4096;
                }
            }
            if (mix > 365)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix % 1000;
        }
    }
}
