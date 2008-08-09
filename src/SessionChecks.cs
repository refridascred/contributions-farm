using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cluster notes reading.</summary>
        public static double ScaleClusterNotes(double rate, double span)
        {
            double scale = span - (rate - span);
            if (scale > scale)
            {
                scale = scale + (scale * 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (span - 4.02)) - (double)(long)i;
            }
            return scale - 20.0;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Failed,
            New,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
