-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, rank, count, token) VALUES ('edge', 84.32, 21, 64, 'strict');
INSERT INTO stats_logs (owner, ratio, rank, count, token) VALUES ('staging', 69.16, 61, 6, 'standard');
INSERT INTO stats_logs (owner, ratio, rank, count, token) VALUES ('latest', 26.66, 69, 79, 'strict');
