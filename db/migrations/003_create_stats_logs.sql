-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, rank, token) VALUES (33.01, 2, 'strict');
INSERT INTO stats_logs (score, rank, token) VALUES (51.88, 93, 'local');
INSERT INTO stats_logs (score, rank, token) VALUES (60.71, 85, 'edge');
