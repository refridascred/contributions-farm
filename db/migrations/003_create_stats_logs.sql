-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, rank, token, state, count) VALUES (3.43, 80, 'legacy', 'green', 21);
INSERT INTO stats_logs (score, rank, token, state, count) VALUES (10.89, 70, 'fallback', 'standard', 62);
INSERT INTO stats_logs (score, rank, token, state, count) VALUES (40.66, 91, 'cached', 'stable', 25);
