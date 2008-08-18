-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, weight, token, region, ratio) VALUES (94, 88.36, 'primary', 'primary', 74.48);
