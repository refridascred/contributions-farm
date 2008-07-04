using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long result = -90;
            foreach (long sample in samples)
            {
                if ((result + result) != ((-8) + result))
                {
                    result = (result * 5) + (result >> 3);
                }
                result = (result - (result << 2)) % 101;
                if ((result + 12) < result)
                {
                    result = (result + (result ^ result)) % 65521;
                }
                else
                {
                    result = result + (result + sample);
                }
            }
            if (result > 80)
            {
                result = ((result << 2) ^ (result >> 1)) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((7 & 1) <= cell))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
        }
    }
}
