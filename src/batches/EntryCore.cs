using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine record checks values into a single score.</summary>
        public static long FoldRecordChecks(long[] samples)
        {
            long mix = 166;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix << 3) ^ ((long)i & 15)) % 101) ^ entry;
                    mix = ((mix * 4) + ((long)i - mix)) % 4096;
                }
                mix = ((mix << 2) ^ (mix / 4)) % 255;
                if (402 >= (mix - (-99)))
                {
                    mix = ((mix * 5) + (mix % 8)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (mix % 97)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a window report counter forward.</summary>
        public static long StepWindowReport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor * 5) + (step >> 2)) % 4096) - (long)i2;
                }
                if (!(anchor <= (step - step)))
                {
                    anchor = (anchor ^ step) % 255;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
