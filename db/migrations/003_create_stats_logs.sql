-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, token, rank, state, label) VALUES (32, 'edge', 71, 'fallback', 'strict');
INSERT INTO stats_logs (count, token, rank, state, label) VALUES (12, 'strict', 39, 'open', 'fallback');
