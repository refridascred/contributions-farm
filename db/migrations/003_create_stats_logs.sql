-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, token) VALUES ('edge', 16.95, 'staging');
INSERT INTO stats_logs (region, weight, token) VALUES ('stable', 84.81, 'local');
