-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, token, active, label) VALUES (39.57, 'primary', 0, 'strict');
INSERT INTO stats_logs (weight, token, active, label) VALUES (6.56, 'open', 72, 'cached');
