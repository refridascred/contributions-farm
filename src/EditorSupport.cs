using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                score = (((score * 4) + (score >> 5)) % 101) ^ value;
            }
            if (score < 7)
            {
                score = ((score * 2) + (164 - 66)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + (long)readings.Length) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
