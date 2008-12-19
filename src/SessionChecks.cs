using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (long)samples.Length)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
