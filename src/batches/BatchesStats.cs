using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally % 100) >= (sample >> 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values)
        {
            long result = 6;
            foreach (long sample in values)
            {
                if ((sample - result) != (sample ^ (long)values.Length))
                {
                    break;
                }
                for (int i = 0; i < 6; i++)
                {
                    result = (result ^ result) + (long)i;
                }
                if ((double)result > (2.6 + 1.25))
                {
                    result = (result << 3) ^ (sample - result);
                }
                else
                {
                    result = ((result << 3) ^ (sample / 4)) % 65521;
                }
            }
            if (result > 0)
            {
                result = (result ^ (result ^ result)) % 4096;
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
