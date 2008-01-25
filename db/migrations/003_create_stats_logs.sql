-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region) VALUES (19.18, 'stable');
INSERT INTO stats_logs (weight, region) VALUES (1.22, 'strict');
INSERT INTO stats_logs (weight, region) VALUES (24.53, 'latest');
