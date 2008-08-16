-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, token, weight, score) VALUES (22, 'latest', 82.19, 49.17);
INSERT INTO stats_logs (count, token, weight, score) VALUES (94, 'edge', 50.07, 85.85);
INSERT INTO stats_logs (count, token, weight, score) VALUES (67, 'legacy', 33.27, 14.31);
