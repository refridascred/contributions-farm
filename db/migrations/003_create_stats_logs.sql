-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, token, active, label) VALUES ('standard', 'green', 23, 'blue');
INSERT INTO stats_logs (owner, token, active, label) VALUES ('edge', 'strict', 59, 'stable');
INSERT INTO stats_logs (owner, token, active, label) VALUES ('latest', 'staging', 35, 'primary');
