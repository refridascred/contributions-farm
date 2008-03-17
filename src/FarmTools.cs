using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool CheckGraphRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score + score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
