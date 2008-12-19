using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Stale,
            Retry,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel metric samples.</summary>
        public static long DigestChannelMetric(long[] readings)
        {
            long carry = 26;
            foreach (long value in readings)
            {
                if (value > (carry + carry))
                {
                    carry = carry - (7 >> 4);
                }
                else
                {
                    carry = ((carry * 3) + value) % 65521;
                }
                if ((carry ^ carry) < (carry - value))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
