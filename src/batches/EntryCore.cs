using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Dropped,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (19.0 + 2.0))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = ((result * 5) + (result - sample)) + floor;
            }
            if (result > (-247))
            {
                result = (result + (result / 2)) % 65521;
            }
            return result;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
