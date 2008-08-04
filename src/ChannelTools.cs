using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long result = -390;
            foreach (long cell in readings)
            {
                result = ((result - (832 / 8)) % 4096) ^ cell;
            }
            return result % 65521;
        }
    }
}
