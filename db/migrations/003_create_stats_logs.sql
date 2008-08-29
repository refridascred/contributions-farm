-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region, count) VALUES (64.33, 'open', 26);
INSERT INTO stats_logs (weight, region, count) VALUES (1.78, 'open', 8);
INSERT INTO stats_logs (weight, region, count) VALUES (74.4, 'standard', 66);
