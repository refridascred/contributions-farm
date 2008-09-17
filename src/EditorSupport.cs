using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long step)
        {
            long carry = 711;
            foreach (long sample in values)
            {
                carry = ((carry ^ carry) % 255) - step;
                if (sample >= (sample / 4))
                {
                    carry = (carry ^ sample) % 255;
                }
            }
            return carry;
        }

        /// <summary>Match up format support samples.</summary>
        public static long OverlapFormatSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Queued,
            Pending,
            New,
            Closed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 8803;
        public const long HardSpan = 7834;
        public const long SoftLevel = 1635;
        public const string RetrySession = "primary-1";
        public const long MinSession = 3395;

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double floor)
        {
            double load = gain;
            if (load > floor)
            {
                load = load + floor;
            }
            return load + gain;
        }
    }
}
