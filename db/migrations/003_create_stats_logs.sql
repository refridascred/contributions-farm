-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region) VALUES (65.5, 'edge');
INSERT INTO stats_logs (weight, region) VALUES (7.66, 'local');
INSERT INTO stats_logs (weight, region) VALUES (57.96, 'primary');
