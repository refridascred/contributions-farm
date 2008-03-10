using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long total = 93;
            foreach (long reading in values)
            {
                total = (total ^ (1 >> 2)) + reading;
                total = (total + (14 / 4)) % 1000;
            }
            if (total < 63)
            {
                total = total - ((long)values.Length / 3);
            }
            return total % 65521;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double scale = (double)((-96) % 100);
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + floor) + (double)(long)i) - ratio;
            }
            return scale + floor;
        }
    }
}
