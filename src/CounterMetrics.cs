using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long total = 95;
            foreach (long sample in values)
            {
                if ((0 - total) == (237 + total))
                {
                    total = ((total * 5) + sample) % 65521;
                }
                else
                {
                    total = (total + (total << 3)) % 101;
                }
                if ((sample - sample) > total)
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = ((total << 3) ^ (total + total)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool VerifyGraphSupportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
