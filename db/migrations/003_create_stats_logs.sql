-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, state, label, token, owner) VALUES (44, 'local', 'blue', 'standard', 'stable');
INSERT INTO stats_logs (rank, state, label, token, owner) VALUES (30, 'cached', 'staging', 'stable', 'strict');
INSERT INTO stats_logs (rank, state, label, token, owner) VALUES (33, 'edge', 'standard', 'stable', 'latest');
