using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache layout samples.</summary>
        public static long FoldCacheLayout(long[] series)
        {
            long score = 784;
            foreach (long cell in series)
            {
                if (!((score % 97) > (cell + score)))
                {
                    score = ((score << 3) ^ (cell % 64)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}
