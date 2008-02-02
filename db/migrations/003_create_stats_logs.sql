-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, weight, label) VALUES ('local', 'local', 67.1, 'edge');
INSERT INTO stats_logs (region, token, weight, label) VALUES ('primary', 'green', 13.47, 'open');
