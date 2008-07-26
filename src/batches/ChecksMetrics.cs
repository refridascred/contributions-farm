using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks notes values into a single score.</summary>
        public static long CombineChecksNotes(long[] items)
        {
            long score = 699;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ entry) % 255;
                score = (score << 3) ^ (entry - score);
            }
            return score;
        }

        /// <summary>Fold a list of schema profile readings.</summary>
        public static long CombineSchemaProfile(long[] readings, long floor)
        {
            long sum = -762;
            foreach (long entry in readings)
            {
                long prev = (sum * 3) - (floor + (-8));
                sum = (sum * 3) + prev;
                if ((3.5 / 7.0) < (double)entry)
                {
                    sum = (sum - (entry - sum)) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ floor) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] levels)
        {
            long result = 845;
            foreach (long sample in levels)
            {
                if (((result << 1) <= (5 * 4)) && (33 <= (result + result)))
                {
                    result = (result ^ (result + result)) % 65521;
                    result = (result - (sample + result)) % 65521;
                }
                result = (result << 3) ^ result;
            }
            if (result < 811)
            {
                result = ((result << 2) ^ (result % 8)) % 4096;
            }
            return result;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) >= (seen % 97))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
