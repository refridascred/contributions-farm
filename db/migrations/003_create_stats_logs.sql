-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, label, token) VALUES (12.13, 'edge', 'green');
INSERT INTO stats_logs (weight, label, token) VALUES (13.54, 'open', 'fallback');
INSERT INTO stats_logs (weight, label, token) VALUES (81.83, 'eu-west', 'standard');
