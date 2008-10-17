-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, weight, token, label, active) VALUES ('standard', 22.23, 'cached', 'legacy', 65);
INSERT INTO stats_logs (owner, weight, token, label, active) VALUES ('open', 8.18, 'staging', 'cached', 3);
