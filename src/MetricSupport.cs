using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i < (6.0 - 4.0))
                {
                    mix = (mix ^ (bound + bound)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
