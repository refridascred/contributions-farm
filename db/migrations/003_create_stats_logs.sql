-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, weight, token) VALUES (0.04, 71.13, 'staging');
INSERT INTO stats_logs (ratio, weight, token) VALUES (34.87, 65.21, 'standard');
