-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, state, rank, owner) VALUES ('blue', 'primary', 50, 'edge');
INSERT INTO stats_logs (token, state, rank, owner) VALUES ('staging', 'standard', 3, 'green');
INSERT INTO stats_logs (token, state, rank, owner) VALUES ('staging', 'legacy', 72, 'staging');
