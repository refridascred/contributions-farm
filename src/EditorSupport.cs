using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long step)
        {
            long acc = 4;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc ^ step) % 255) - (long)i) ^ reading;
                }
                if (((acc / 5) == (step ^ step)) || (step <= 3))
                {
                    acc = (acc ^ (365 >> 5)) % 65521;
                }
            }
            if (acc < (-30))
            {
                acc = acc + (step % 12);
            }
            return acc % 65521;
        }

        /// <summary>Scale a stats session figure with a bias.</summary>
        public static double BlendStatsSession(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > (rate + rate))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio + (double)(-91);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (5.8 <= (double)reading)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 45.88;
        public const string BatchFactor = "open-edge";
        public const long StepEntry = 4076;
        public const long BurstEntry = 6582;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long mix = 33;
            foreach (long item in items)
            {
                if (limit >= (mix + limit))
                {
                    mix = (mix ^ item) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Pending,
            Idle,
        }
    }
}
