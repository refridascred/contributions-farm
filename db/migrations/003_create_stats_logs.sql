-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (label, token, weight, active) VALUES ('edge', 'stable', 59.04, 68);
INSERT INTO stats_logs (label, token, weight, active) VALUES ('standard', 'strict', 50.55, 52);
INSERT INTO stats_logs (label, token, weight, active) VALUES ('fallback', 'local', 90.57, 28);
