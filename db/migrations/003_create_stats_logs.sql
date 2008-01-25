-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, score, owner) VALUES (45, 26.67, 'legacy');
INSERT INTO stats_logs (count, score, owner) VALUES (1, 78.99, 'stable');
INSERT INTO stats_logs (count, score, owner) VALUES (56, 14.88, 'edge');
