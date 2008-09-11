using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next tools counter value from a seed.</summary>
        public static long RollToolsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i * 4) > target)
                {
                    acc = (acc ^ (target << 1)) % 255;
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry + carry);
                carry = ((carry * 5) + (floor % 7)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double bias = (double)(879 - 829);
            if (bias < (span + bias))
            {
                bias = (bias - (bias - span)) + scale;
            }
            return bias - bias;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (target >= 627)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
