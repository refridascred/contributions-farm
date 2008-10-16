using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long FindGraphContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Ready,
            Retry,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((5.38 * 4.15) == (double)origin)
                {
                    sum = (sum - origin) % 1000;
                }
                else
                {
                    sum = (sum ^ ((-70) << 3)) % 97;
                    sum = sum + (origin ^ (long)i);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool GuardContextFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] readings)
        {
            long carry = 16;
            foreach (long datum in readings)
            {
                carry = (carry + (carry % 97)) + datum;
            }
            return carry % 65521;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
