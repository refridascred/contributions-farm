-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, count, region, score) VALUES (65.31, 35.96, 37, 'legacy', 10.22);
INSERT INTO stats_logs (ratio, weight, count, region, score) VALUES (42.02, 26.07, 39, 'latest', 8.35);
