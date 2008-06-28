-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, region, count) VALUES (64.28, 'cached', 34);
INSERT INTO stats_logs (ratio, region, count) VALUES (86.71, 'edge', 97);
INSERT INTO stats_logs (ratio, region, count) VALUES (96.35, 'green', 93);
