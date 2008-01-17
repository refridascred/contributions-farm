using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultCount = 74.58;
        public const long LimitGithubfarm = 792;
        public const long IdleSpan = 5945;
        public const double StepGithubfarm = 55.87;
        public const string SoftGithubfarm = "standard";

        /// <summary>Combine stream payload values into a single score.</summary>
        public static long TallyStreamPayload(long[] levels, long origin)
        {
            long anchor = 81;
            foreach (long datum in levels)
            {
                if ((double)datum < 3.4)
                {
                    anchor = anchor ^ (anchor & 127);
                }
                if ((origin ^ datum) == (datum / 8))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < (9.3 / 5.0))
                {
                    matches = ((matches + 1) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Rank profile notes input into a small class.</summary>
        public static long GradeProfileNotes(long seed, long target)
        {
            if (!(target <= (4 + target)))
            {
                return 2;
            }
            else
            {
                if (((seed & 127) < (41 % 97)) || ((seed + target) == (seed ^ 7)))
                {
                    return 4;
                }
                else
                {
                    if ((target + 7) >= ((-79) % 64))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target & 31) < target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
