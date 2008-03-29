-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, score, rank, token, owner) VALUES ('stable', 52.47, 12, 'local', 'green');
INSERT INTO stats_logs (region, score, rank, token, owner) VALUES ('strict', 10.16, 61, 'open', 'strict');
INSERT INTO stats_logs (region, score, rank, token, owner) VALUES ('edge', 46.81, 16, 'local', 'green');
