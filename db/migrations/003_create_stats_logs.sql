-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, region, weight) VALUES (58.23, 'open', 25.28);
INSERT INTO stats_logs (ratio, region, weight) VALUES (68.91, 'local', 21.33);
INSERT INTO stats_logs (ratio, region, weight) VALUES (28.41, 'local', 28.14);
