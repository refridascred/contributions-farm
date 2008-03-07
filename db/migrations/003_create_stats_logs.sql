-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, region, ratio) VALUES ('fallback', 'stable', 1.92);
INSERT INTO stats_logs (label, region, ratio) VALUES ('stable', 'fallback', 40.85);
INSERT INTO stats_logs (label, region, ratio) VALUES ('staging', 'legacy', 74.26);
