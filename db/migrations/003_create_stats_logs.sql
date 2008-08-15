-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, ratio, weight, region) VALUES (42, 8.89, 35.23, 'eu-west');
INSERT INTO stats_logs (count, ratio, weight, region) VALUES (40, 65.84, 13.95, 'fallback');
INSERT INTO stats_logs (count, ratio, weight, region) VALUES (4, 63.02, 89.32, 'open');
