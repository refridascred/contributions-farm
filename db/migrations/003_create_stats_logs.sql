-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, owner, score, token) VALUES (78, 'latest', 27.37, 'open');
INSERT INTO stats_logs (rank, owner, score, token) VALUES (21, 'legacy', 47.9, 'open');
INSERT INTO stats_logs (rank, owner, score, token) VALUES (36, 'local', 93.44, 'edge');
