using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (15.0 * 8.6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double ratio2 = span;
            return (ratio2 + (double)1) + ratio;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double scale, double offset)
        {
            double gain = offset;
            return (gain + (3.4 * 9.17)) + scale;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
