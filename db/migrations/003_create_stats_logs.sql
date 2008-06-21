-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, owner, weight, state, ratio) VALUES (37, 'legacy', 93.99, 'stable', 95.95);
INSERT INTO stats_logs (rank, owner, weight, state, ratio) VALUES (8, 'standard', 31.28, 'fallback', 13.0);
