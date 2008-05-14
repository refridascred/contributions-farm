-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, state, rank) VALUES (1.32, 'stable', 76);
INSERT INTO stats_logs (score, state, rank) VALUES (13.03, 'fallback', 78);
INSERT INTO stats_logs (score, state, rank) VALUES (86.06, 'local', 68);
