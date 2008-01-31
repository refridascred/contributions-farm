-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, rank, active, level, token) VALUES ('local', 97, 78, 56, 'eu-west');
INSERT INTO stats_logs (label, rank, active, level, token) VALUES ('standard', 66, 90, 88, 'local');
