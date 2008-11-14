-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, owner, count, token) VALUES (94, 5.45, 'cached', 17, 'edge');
INSERT INTO stats_logs (rank, ratio, owner, count, token) VALUES (46, 17.99, 'latest', 1, 'strict');
INSERT INTO stats_logs (rank, ratio, owner, count, token) VALUES (59, 32.69, 'fallback', 10, 'blue');
