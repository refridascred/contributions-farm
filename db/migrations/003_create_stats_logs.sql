-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, state, rank) VALUES ('blue', 'fallback', 20);
INSERT INTO stats_logs (token, state, rank) VALUES ('blue', 'latest', 22);
INSERT INTO stats_logs (token, state, rank) VALUES ('staging', 'local', 47);
