-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, state, token, owner, score) VALUES (60, 'latest', 'green', 'strict', 40.14);
INSERT INTO stats_logs (rank, state, token, owner, score) VALUES (46, 'edge', 'stable', 'stable', 31.14);
INSERT INTO stats_logs (rank, state, token, owner, score) VALUES (6, 'local', 'local', 'open', 71.62);
