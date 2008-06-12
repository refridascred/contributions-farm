-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, count, owner, ratio, region) VALUES ('legacy', 16, 'stable', 56.86, 'fallback');
INSERT INTO stats_logs (label, count, owner, ratio, region) VALUES ('edge', 83, 'open', 68.81, 'primary');
INSERT INTO stats_logs (label, count, owner, ratio, region) VALUES ('legacy', 38, 'standard', 42.7, 'latest');
