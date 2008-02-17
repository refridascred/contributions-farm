-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, token, label, active) VALUES (38.92, 'edge', 'blue', 65);
INSERT INTO stats_logs (ratio, token, label, active) VALUES (11.02, 'local', 'edge', 68);
