using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long step)
        {
            long score = 2;
            foreach (long sample in values)
            {
                if ((step <= (step >> 1)) && ((double)655 == (double)step))
                {
                    score = ((score - (step - step)) % 101) ^ sample;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data)
        {
            long anchor = 41;
            foreach (long reading in data)
            {
                if ((8.97 * 3.07) > (double)reading)
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - (reading - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Failed,
            Paused,
            Stale,
        }
    }
}
