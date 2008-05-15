-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, state, active) VALUES ('fallback', 10, 'fallback', 39);
INSERT INTO stats_logs (owner, rank, state, active) VALUES ('legacy', 19, 'staging', 27);
INSERT INTO stats_logs (owner, rank, state, active) VALUES ('blue', 94, 'eu-west', 71);
