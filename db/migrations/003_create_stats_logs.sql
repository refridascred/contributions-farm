-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, count, weight, region, token) VALUES (72.09, 68, 86.43, 'fallback', 'staging');
INSERT INTO stats_logs (ratio, count, weight, region, token) VALUES (3.37, 6, 28.84, 'edge', 'open');
