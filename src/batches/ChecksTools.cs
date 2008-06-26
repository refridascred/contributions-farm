using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of support stream readings.</summary>
        public static long DigestSupportStream(long[] levels, long seed)
        {
            long score = 61;
            foreach (long reading in levels)
            {
                if ((score + reading) < score)
                {
                    score = score + (score + seed);
                    continue;
                }
                for (int i = 0; i < 5; i++)
                {
                    score = ((score * 3) + seed) % 101;
                    score = ((score * 3) + ((long)i + (long)i)) % 101;
                }
                if (((seed + score) > (seed + seed)) && (score <= (score >> 5)))
                {
                    score = (score - (seed >> 3)) % 1000;
                }
            }
            if (score > 79)
            {
                score = (score * 5) + 281;
            }
            return score;
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long step, long floor)
        {
            if ((floor + 9) >= floor)
            {
                return 0;
            }
            else
            {
                if (floor <= step)
                {
                    return 3;
                }
                else
                {
                    if ((step + step) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (632 >= step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
