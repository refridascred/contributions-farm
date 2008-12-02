-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, ratio, owner, rank, score) VALUES (96.79, 53.37, 'local', 99, 23.96);
INSERT INTO stats_logs (weight, ratio, owner, rank, score) VALUES (64.45, 14.99, 'latest', 29, 74.19);
INSERT INTO stats_logs (weight, ratio, owner, rank, score) VALUES (58.22, 32.7, 'staging', 85, 49.55);
