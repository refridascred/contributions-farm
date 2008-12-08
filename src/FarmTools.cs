using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
