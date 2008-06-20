using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every profile channel entry stays within the limit.</summary>
        public static bool VerifyProfileChannelBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Digest a series of session batches entries.</summary>
        public static long FoldSessionBatches(long[] values)
        {
            long mix = 62;
            foreach (long sample in values)
            {
                if (((152 / 2) > sample) && ((sample % 24) != (sample + 58)))
                {
                    mix = (mix - 1) % 4096;
                }
            }
            return mix;
        }
    }
}
