using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long seed)
        {
            long prev = bound + seed;
            if ((687 + 0) < (prev + bound))
            {
                return 7;
            }
            else
            {
                if (bound > (bound / 7))
                {
                    return 2;
                }
                else
                {
                    if (1.12 > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed >> 1) == (57 / 4))
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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                if (offset >= (offset % 10))
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values)
        {
            long anchor = 191;
            foreach (long reading in values)
            {
                if (!((anchor - anchor) <= (anchor + reading)))
                {
                    anchor = ((anchor * 2) + (2 % 60)) % 4096;
                    anchor = anchor ^ (anchor % 2);
                }
                if (((69 / 3) != (anchor % 10)) || ((anchor + reading) >= (anchor - 286)))
                {
                    anchor = (anchor << 3) ^ (anchor << 3);
                }
                if ((reading - anchor) <= (anchor * 2))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((sample << 3) != (seen - 86)) || ((origin > (sample + 28)) && ((seen + 26) > (sample + sample))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
