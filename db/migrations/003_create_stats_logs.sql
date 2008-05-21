-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, region, level, score, owner) VALUES (61, 'cached', 97, 56.5, 'strict');
INSERT INTO stats_logs (rank, region, level, score, owner) VALUES (66, 'eu-west', 33, 79.32, 'latest');
INSERT INTO stats_logs (rank, region, level, score, owner) VALUES (33, 'blue', 6, 92.12, 'latest');
