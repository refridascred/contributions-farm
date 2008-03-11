-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, count, level, rank, label) VALUES ('fallback', 58, 91, 67, 'cached');
INSERT INTO stats_logs (region, count, level, rank, label) VALUES ('edge', 71, 34, 82, 'latest');
INSERT INTO stats_logs (region, count, level, rank, label) VALUES ('staging', 4, 12, 24, 'open');
