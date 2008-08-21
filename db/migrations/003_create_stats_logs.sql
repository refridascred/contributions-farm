-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, label, owner, active, token) VALUES (17, 'primary', 'stable', 1, 'cached');
INSERT INTO stats_logs (rank, label, owner, active, token) VALUES (53, 'standard', 'strict', 45, 'primary');
