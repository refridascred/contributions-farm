using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSpan = 22.67;
        public const long StepDepth = 7513;
        public const string StepBudget = "cached";

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mix = 7;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 8.73)
                {
                    mix = ((mix * 4) + (datum + mix)) % 101;
                }
            }
            return mix % 97;
        }
    }
}
