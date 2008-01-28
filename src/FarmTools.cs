using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double ratio = 2.0;
            if (ratio >= bias)
            {
                ratio = (ratio - bias) + span;
            }
            else
            {
                ratio = ratio - (11.0 + ratio);
            }
            return ratio - bias;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
