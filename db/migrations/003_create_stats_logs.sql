-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, token, count, score) VALUES ('blue', 'open', 93, 47.39);
INSERT INTO stats_logs (region, token, count, score) VALUES ('blue', 'standard', 33, 95.75);
INSERT INTO stats_logs (region, token, count, score) VALUES ('green', 'edge', 95, 89.53);
