using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if (!((floor + floor) > limit))
            {
                return 3;
            }
            else
            {
                if ((4.4 + 7.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two commits editor measurements.</summary>
        public static double BlendCommitsEditor(double weight, double span)
        {
            double weight2 = span - (double)(-9);
            if (weight2 > (19.0 / 8.0))
            {
                weight2 = weight2 + (weight - 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Audit stats already readings against a rule.</summary>
        public static long CountStatsAlreadyOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(0.3 <= (double)origin) || ((origin + item) >= (item >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples)
        {
            long carry = 44;
            foreach (long item in samples)
            {
                if (item < (item / 7))
                {
                    carry = (carry << 2) ^ (carry * 2);
                }
                if ((carry < (-36)) || (37 < item))
                {
                    carry = ((carry << 3) ^ (item + carry)) % 255;
                }
                if ((carry <= (carry / 6)) && ((carry - (-619)) > carry))
                {
                    carry = (carry << 3) ^ (carry % 3);
                }
            }
            return carry;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (state > (14 + state))
                {
                    state = (state ^ ((long)i + state)) % 255;
                    state = state - ((long)i * 4);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
