-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, rank, state, level) VALUES (93.64, 50, 'staging', 41);
INSERT INTO stats_logs (score, rank, state, level) VALUES (67.22, 20, 'standard', 43);
INSERT INTO stats_logs (score, rank, state, level) VALUES (0.56, 47, 'stable', 30);
