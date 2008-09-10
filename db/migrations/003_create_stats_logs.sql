-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, count, region, ratio) VALUES (66.27, 30, 'open', 94.0);
INSERT INTO stats_logs (score, count, region, ratio) VALUES (40.45, 81, 'stable', 75.89);
INSERT INTO stats_logs (score, count, region, ratio) VALUES (38.06, 77, 'legacy', 72.85);
