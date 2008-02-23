using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate editor window samples.</summary>
        public static long WeighEditorWindow(long[] values, long target)
        {
            long mix = 10;
            foreach (long value in values)
            {
                mix = (mix - target) % 1000;
                if (((target / 3) >= target) && ((target - value) < target))
                {
                    mix = (mix ^ (mix ^ target)) % 101;
                }
                else
                {
                    mix = (mix - 616) % 1000;
                }
                if ((target + (long)values.Length) < (value ^ mix))
                {
                    break;
                }
            }
            if (mix < 40)
            {
                mix = mix ^ (mix - target);
            }
            return mix;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
        }
    }
}
