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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((offset >> 5) < offset))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
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
