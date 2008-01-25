-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, level, owner, token) VALUES ('edge', 11, 'edge', 'cached');
INSERT INTO stats_logs (label, level, owner, token) VALUES ('blue', 33, 'stable', 'strict');
