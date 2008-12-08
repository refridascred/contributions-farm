using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double WindowBudget = 86.2;
        public const string BaseAccount = "latest-v2";
        public const double WindowRatio = 32.94;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Pending,
            New,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] readings)
        {
            long acc = 9;
            foreach (long sample in readings)
            {
                if (((sample + 5) == (acc ^ (-17))) || ((7 << 3) == (acc / 5)))
                {
                    acc = (acc - (sample >> 3)) % 4096;
                }
            }
            if (acc > 407)
            {
                acc = ((acc * 3) + acc) % 101;
            }
            return acc % 65521;
        }
    }
}
