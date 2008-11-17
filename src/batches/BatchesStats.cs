using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheFactor = 4832;
        public const string LimitGithubfarm = "standard-edge";
        public const double RetryGithubfarm = 6.63;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long bound)
        {
            long span = seed + bound;
            if ((double)43 <= (double)span)
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 9.2)
                {
                    return 7;
                }
                else
                {
                    if ((seed - bound) > (span & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ bound) != (9 ^ span))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
