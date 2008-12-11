using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Stale,
            Pending,
            New,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] samples, long bound)
        {
            long anchor = -78;
            foreach (long item in samples)
            {
                if (77 > item)
                {
                    anchor = ((anchor * 3) + (anchor - item)) + bound;
                    continue;
                }
                anchor = ((anchor << 3) ^ (anchor / 5)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a token farm reading.</summary>
        public static double ScaleTokenFarm(double ratio, double offset)
        {
            double gain = ratio * 4.0;
            if (gain <= offset)
            {
                gain = gain + gain;
            }
            return gain - (double)820;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
