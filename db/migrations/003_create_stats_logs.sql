-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, rank, state, score, token) VALUES (55, 54, 'stable', 68.98, 'standard');
INSERT INTO stats_logs (level, rank, state, score, token) VALUES (83, 85, 'blue', 48.03, 'legacy');
INSERT INTO stats_logs (level, rank, state, score, token) VALUES (30, 51, 'strict', 34.8, 'edge');
