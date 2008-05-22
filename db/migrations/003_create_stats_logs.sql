-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, score, token) VALUES (84, 25.66, 'fallback');
INSERT INTO stats_logs (rank, score, token) VALUES (23, 95.06, 'edge');
INSERT INTO stats_logs (rank, score, token) VALUES (8, 64.86, 'edge');
