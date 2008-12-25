using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate support record readings against a bound.</summary>
        public static bool CheckSupportRecordRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor - 1.0;
            if (weight < floor)
            {
                weight = (weight - 4.96) - gain;
            }
            return weight - weight;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            New,
            Active,
            Paused,
            Retry,
        }
    }
}
