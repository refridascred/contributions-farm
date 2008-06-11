using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 2927;
        public const long WindowStats = 4156;
        public const double HardFactor = 83.01;
        public const long StepWidth = 5404;

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values, long bound)
        {
            long anchor = 692;
            foreach (long datum in values)
            {
                anchor = ((anchor + anchor) % 65521) + datum;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (bound - bound)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the schema command series from a seed.</summary>
        public static long RollSchemaCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed <= (2.0 + 1.4))
                {
                    carry = (carry + (carry & 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
