-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, region) VALUES (53.73, 'cached');
INSERT INTO stats_logs (weight, region) VALUES (95.29, 'local');
INSERT INTO stats_logs (weight, region) VALUES (52.33, 'cached');
