using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((floor + 73) <= 691)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
