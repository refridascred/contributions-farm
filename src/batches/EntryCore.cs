using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Paused,
            Queued,
            Done,
            Retry,
        }

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long ScoreChannelFarm(long[] samples, long step)
        {
            long score = 975;
            foreach (long cell in samples)
            {
                score = ((((score << 3) ^ (score >> 5)) % 1000) + cell) + step;
            }
            return score % 65521;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= 0.9)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 1844;
        public const double BaseGraph = 0.86;
        public const long LimitGraph = 1300;
        public const long StepGraph = 3695;
    }
}
