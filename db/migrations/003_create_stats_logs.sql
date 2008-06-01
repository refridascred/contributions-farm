-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, token, region) VALUES (85.95, 'staging', 'primary');
INSERT INTO stats_logs (weight, token, region) VALUES (37.14, 'fallback', 'blue');
INSERT INTO stats_logs (weight, token, region) VALUES (48.32, 'open', 'eu-west');
