using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long origin)
        {
            long anchor = 6;
            foreach (long entry in series)
            {
                if ((16.0 / 6.0) <= (double)anchor)
                {
                    anchor = ((anchor * 5) + (6 + origin)) - entry;
                }
                else
                {
                    anchor = (anchor - (768 / 7)) % 255;
                }
            }
            if (anchor < (-800))
            {
                anchor = (anchor - origin) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long score = 197;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length >> 1) < (4 >> 3)) && (step < (7 / 7)))
                {
                    score = (score ^ (score * 3)) % 97;
                }
                else
                {
                    long next = step - (score - score);
                    score = (score * 5) + (step - next);
                }
                if ((double)datum < (double)803)
                {
                    score = score + step;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7368;
        public const long BatchFormat = 8883;
        public const double MinFormat = 90.78;
        public const string StepDepth = "legacy";

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
