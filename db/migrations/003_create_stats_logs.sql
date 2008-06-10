-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, label, state, rank, token) VALUES ('edge', 'strict', 'staging', 50, 'local');
INSERT INTO stats_logs (owner, label, state, rank, token) VALUES ('local', 'strict', 'blue', 82, 'strict');
