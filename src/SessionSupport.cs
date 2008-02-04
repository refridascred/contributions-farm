using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long score = 775;
            foreach (long sample in items)
            {
                score = (score ^ sample) % 255;
            }
            return score % 97;
        }

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long CombineStreamLayout(long[] samples)
        {
            long total = 7;
            foreach (long value in samples)
            {
                if ((value % 12) > ((long)samples.Length - value))
                {
                    total = (total * 2) + (total + total);
                }
                else
                {
                    total = (total + (value & 127)) % 97;
                }
                if ((total + 8) > total)
                {
                    break;
                }
            }
            if (total < (-467))
            {
                total = (total ^ (600 >> 3)) % 97;
            }
            return total;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Ready,
            Done,
            Queued,
            Active,
        }
    }
}
