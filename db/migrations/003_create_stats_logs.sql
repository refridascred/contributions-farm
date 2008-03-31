-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, region, score) VALUES (6.53, 'blue', 56.48);
INSERT INTO stats_logs (ratio, region, score) VALUES (8.78, 'blue', 73.18);
INSERT INTO stats_logs (ratio, region, score) VALUES (50.83, 'edge', 69.1);
