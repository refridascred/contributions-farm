-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, owner, count, token, ratio) VALUES (28.39, 'local', 90, 'fallback', 74.86);
INSERT INTO stats_logs (score, owner, count, token, ratio) VALUES (93.13, 'strict', 38, 'cached', 27.4);
INSERT INTO stats_logs (score, owner, count, token, ratio) VALUES (36.47, 'stable', 41, 'legacy', 61.41);
