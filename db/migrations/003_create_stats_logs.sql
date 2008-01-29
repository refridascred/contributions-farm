-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count) VALUES (30.69, 68);
INSERT INTO stats_logs (ratio, count) VALUES (5.71, 85);
INSERT INTO stats_logs (ratio, count) VALUES (58.12, 42);
