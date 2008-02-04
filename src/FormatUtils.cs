using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 3619;
        public const long DefaultInterval = 513;
        public const long WindowLayout = 8699;
        public const double BatchRatio = 90.65;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long seed)
        {
            long anchor = 942;
            foreach (long datum in items)
            {
                if (datum < (40 - datum))
                {
                    anchor = ((anchor * 2) + (seed + anchor)) % 1000;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
