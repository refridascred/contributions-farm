using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 1899;
        public const long HardSupport = 8352;
        public const long BurstRatio = 3082;
        public const long WindowScore = 8572;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count <= (double)769)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics command counter forward.</summary>
        public static long DeriveMetricsCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                if ((13.0 / 8.0) < (double)total)
                {
                    total = (total * 3) + (target % 100);
                }
                else
                {
                    total = (total - ((long)i << 2)) % 65521;
                    total = total + (target & 255);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
