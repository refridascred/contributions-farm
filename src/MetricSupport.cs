using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Retry,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long carry = 28;
            foreach (long reading in items)
            {
                carry = carry ^ (reading ^ 4);
                if (!((reading ^ reading) > carry))
                {
                    carry = (carry ^ ((-9) / 2)) % 1000;
                }
                if (((double)carry > (9.4 / 2.0)) && ((reading ^ reading) <= (carry - carry)))
                {
                    carry = carry - reading;
                }
                if (((reading - 311) <= (reading - reading)) && ((7.3 - 6.9) > (double)carry))
                {
                    break;
                }
            }
            if (carry > 60)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }
    }
}
