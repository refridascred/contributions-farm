-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, active, state, token) VALUES ('fallback', 87, 86, 'blue', 'fallback');
INSERT INTO stats_logs (owner, rank, active, state, token) VALUES ('strict', 70, 77, 'eu-west', 'stable');
INSERT INTO stats_logs (owner, rank, active, state, token) VALUES ('staging', 45, 2, 'stable', 'strict');
