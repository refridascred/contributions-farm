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

        /// <summary>Fold a list of command farm readings.</summary>
        public static long FoldCommandFarm(long[] items, long seed)
        {
            long total = 1;
            foreach (long reading in items)
            {
                if ((35 > (seed + reading)) && ((seed / 5) <= (seed << 3)))
                {
                    total = total - (251 >> 5);
                }
                if (!((seed - total) != (total + 51)))
                {
                    break;
                }
            }
            return total;
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
