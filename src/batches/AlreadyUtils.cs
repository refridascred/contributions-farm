using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double gain, double bias)
        {
            double load = (double)4 / 3.0;
            if (load > (double)45)
            {
                load = ((load - load) + gain) - bias;
            }
            else
            {
                load = load + (double)248;
            }
            return load + (load / 6.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseInterval = 2.6;
        public const long MinSpan = 9894;
        public const string DefaultSchema = "strict";
        public const long SoftSchema = 2947;
        public const long StepSchema = 9402;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long origin)
        {
            if ((double)target > (2.04 + 1.0))
            {
                return 3;
            }
            else
            {
                if (8.0 < (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((origin << 1) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target & 15) >= (origin >> 3)) || ((target + 347) <= (2 - origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
