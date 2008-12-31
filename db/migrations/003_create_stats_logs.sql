-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, ratio, label, token) VALUES (55, 44.35, 'primary', 'latest');
INSERT INTO stats_logs (active, ratio, label, token) VALUES (1, 45.86, 'standard', 'standard');
