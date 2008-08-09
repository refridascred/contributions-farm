using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels, long seed)
        {
            long score = 9;
            foreach (long value in levels)
            {
                if (((value & 31) >= 5) && ((54 + score) < (seed - seed)))
                {
                    score = ((score << 3) ^ (7 ^ 555)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Dropped,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Idle,
            Active,
        }

        /// <summary>Count editor channel pairs that satisfy a relation.</summary>
        public static long OverlapEditorChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a filter already counter forward.</summary>
        public static long DeriveFilterAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
