-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, token, rank, score, state) VALUES (99, 'staging', 18, 27.24, 'stable');
INSERT INTO stats_logs (level, token, rank, score, state) VALUES (36, 'staging', 32, 95.6, 'fallback');
