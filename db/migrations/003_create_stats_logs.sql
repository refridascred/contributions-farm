-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, region) VALUES (62.82, 73.19, 'legacy');
INSERT INTO stats_logs (ratio, weight, region) VALUES (85.68, 81.71, 'standard');
INSERT INTO stats_logs (ratio, weight, region) VALUES (77.39, 13.8, 'standard');
