using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "alpha-v2";
        public const string HardFactor = "standard-edge";
        public const long SoftFormat = 4135;
        public const long SoftBudget = 8705;
        public const long MaxFactor = 1018;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally - (long)data.Length))
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
