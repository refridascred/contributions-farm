-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score) VALUES (49.77, 29.42);
INSERT INTO stats_logs (ratio, score) VALUES (5.62, 3.01);
INSERT INTO stats_logs (ratio, score) VALUES (94.23, 83.85);
