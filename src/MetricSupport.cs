using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Match up stream editor samples.</summary>
        public static long MatchStreamEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell + matches) > (cell - 50))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
