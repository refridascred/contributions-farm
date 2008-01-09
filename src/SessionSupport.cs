using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long floor, long step)
        {
            long slot = floor ^ step;
            if ((step + slot) >= (673 * 2))
            {
                return 7;
            }
            else
            {
                if ((floor / 6) != (1 & 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
