using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long carry = 4;
            foreach (long item in values)
            {
                if ((carry - (-2)) <= (carry ^ step))
                {
                    carry = carry - (item + carry);
                }
                carry = (carry + (step - (-14))) % 4096;
            }
            if (carry > (-5))
            {
                carry = (carry + (carry + carry)) % 255;
            }
            return carry;
        }
    }
}
