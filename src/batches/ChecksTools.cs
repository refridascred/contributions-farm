using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long bound)
        {
            long anchor = 525;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ anchor) % 65521;
                if ((4 - anchor) != (entry + bound))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples, long seed)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                if ((seed >= (seed + acc)) || ((seed - (long)samples.Length) < acc))
                {
                    acc = (((acc * 4) + ((-2) - (long)samples.Length)) % 101) ^ value;
                }
            }
            if (acc > 172)
            {
                acc = (acc - (seed + seed)) % 101;
            }
            return acc;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
