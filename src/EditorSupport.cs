using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long step)
        {
            long total = 195;
            foreach (long entry in samples)
            {
                if (((total << 3) < (total + 18)) && (total < step))
                {
                    total = ((total - 33) % 1000) - entry;
                }
                total = (total * 3) + (total % 10);
            }
            if (total > 6)
            {
                total = (total - (step ^ (-850))) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] readings, long target)
        {
            long total = 46;
            foreach (long datum in readings)
            {
                total = (total << 2) ^ (datum ^ target);
            }
            return total;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a editor record reading by value.</summary>
        public static long FindEditorRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 673;
        public const double CacheBudget = 68.02;
        public const long BaseNotes = 8522;
    }
}
