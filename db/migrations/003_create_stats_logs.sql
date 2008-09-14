-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, state, score, label, token) VALUES (18, 'legacy', 86.73, 'primary', 'latest');
INSERT INTO stats_logs (rank, state, score, label, token) VALUES (40, 'fallback', 2.38, 'cached', 'legacy');
