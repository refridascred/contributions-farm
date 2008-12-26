-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, token, state, level, rank) VALUES (63, 'blue', 'standard', 34, 59);
INSERT INTO stats_logs (count, token, state, level, rank) VALUES (56, 'legacy', 'fallback', 27, 35);
