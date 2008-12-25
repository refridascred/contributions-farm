using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((135 >> 1) >= bound) && ((anchor * 2) <= anchor))
                {
                    anchor = (anchor + (long)i) % 97;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a format notes pair into a bucket.</summary>
        public static long SortFormatNotes(long seed, long seed2)
        {
            long delta = seed ^ seed2;
            if ((499 - seed) > (seed >> 1))
            {
                return 3;
            }
            else
            {
                if (((double)delta <= (7.4 * 11.0)) || ((0.3 / 2.0) < (double)delta))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed == (3.0 * 20.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)seed != (0.3 * 8.9)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading ^ 681) > (matches - reading)) && (reading <= (matches % 64)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema cache entries.</summary>
        public static long DigestSchemaCache(long[] levels, long target)
        {
            long state = 127;
            foreach (long entry in levels)
            {
                if ((entry + target) > entry)
                {
                    state = state ^ target;
                }
            }
            if (state > 0)
            {
                state = (state ^ (target + target)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Active,
            Closed,
            Stale,
        }
    }
}
