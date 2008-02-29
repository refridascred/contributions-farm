-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (token, rank, score, count, owner) VALUES ('latest', 19, 46.24, 27, 'local');
INSERT INTO stats_logs (token, rank, score, count, owner) VALUES ('stable', 47, 61.95, 7, 'blue');
INSERT INTO stats_logs (token, rank, score, count, owner) VALUES ('primary', 86, 40.15, 94, 'cached');
