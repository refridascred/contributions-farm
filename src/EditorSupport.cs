using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstDepth = "staging-edge";
        public const long MaxSpan = 3789;
        public const long MinSize = 3509;

        /// <summary>Project the next report profile value.</summary>
        public static double AdjustReportProfile(double gain, double span)
        {
            double scale = 8.43;
            if (scale <= gain)
            {
                scale = scale - (scale * 8.4);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Draft,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ ((-393) - (long)i)) % 97;
                carry = (carry << 3) ^ (carry - (long)i);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed + 4) < (sum + sum))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 8.73)
                {
                    mix = ((mix * 4) + (datum + mix)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
