-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, region, weight) VALUES (73.39, 'blue', 57.44);
INSERT INTO stats_logs (ratio, region, weight) VALUES (47.47, 'eu-west', 85.02);
INSERT INTO stats_logs (ratio, region, weight) VALUES (83.34, 'eu-west', 18.87);
