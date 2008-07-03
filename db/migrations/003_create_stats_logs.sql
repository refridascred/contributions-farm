-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, state, token, owner) VALUES (64, 'standard', 'eu-west', 'edge');
INSERT INTO stats_logs (rank, state, token, owner) VALUES (72, 'cached', 'strict', 'latest');
INSERT INTO stats_logs (rank, state, token, owner) VALUES (0, 'legacy', 'standard', 'primary');
