using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of schema session entries.</summary>
        public static long TotalSchemaSession(long[] values, long origin)
        {
            long result = 6;
            foreach (long reading in values)
            {
                if ((reading + result) >= (reading << 1))
                {
                    result = (result * 2) + (origin % 16);
                }
                else
                {
                    result = (result ^ 67) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Digest a series of already metrics entries.</summary>
        public static long DigestAlreadyMetrics(long[] items, long step)
        {
            long sum = 774;
            foreach (long value in items)
            {
                if ((sum / 9) <= sum)
                {
                    sum = (sum - (step + 946)) - value;
                }
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 7225;
        public const double BurstAccount = 32.97;
        public const long IdleLevel = 8173;
    }
}
