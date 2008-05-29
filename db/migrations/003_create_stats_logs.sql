-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, score, token, owner) VALUES (14, 47.8, 'fallback', 'strict');
INSERT INTO stats_logs (count, score, token, owner) VALUES (20, 63.69, 'green', 'strict');
INSERT INTO stats_logs (count, score, token, owner) VALUES (10, 60.27, 'cached', 'primary');
