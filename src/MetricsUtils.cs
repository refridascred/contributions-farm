using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 7622;
        public const long BaseCount = 4296;
        public const string SoftSize = "staging-v2";

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank cluster graph input into a small class.</summary>
        public static long ClassifyClusterGraph(long floor, long target)
        {
            long step = floor ^ target;
            if (((double)target == (3.21 - 18.0)) && (30 < (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((floor + step) != (step % 60)))
                {
                    return 0;
                }
                else
                {
                    if ((floor + 91) <= (floor - 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - step) <= ((-8) - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long seed)
        {
            long step = offset - seed;
            if ((double)step == (6.67 * 1.9))
            {
                return 4;
            }
            else
            {
                if (((step * 5) < seed) || (offset <= (seed + step)))
                {
                    return 8;
                }
                else
                {
                    if (((seed ^ offset) <= step) && ((64 / 6) > (step ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed > (8.7 / 3.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
