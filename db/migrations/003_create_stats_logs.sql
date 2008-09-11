-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, score, rank, state, count) VALUES ('open', 83.37, 20, 'primary', 11);
INSERT INTO stats_logs (token, score, rank, state, count) VALUES ('edge', 44.28, 16, 'fallback', 62);
INSERT INTO stats_logs (token, score, rank, state, count) VALUES ('latest', 83.23, 85, 'green', 89);
