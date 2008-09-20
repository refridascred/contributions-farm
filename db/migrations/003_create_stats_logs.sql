-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, label, count, token) VALUES (69.59, 'blue', 78, 'stable');
INSERT INTO stats_logs (weight, label, count, token) VALUES (42.6, 'open', 96, 'green');
