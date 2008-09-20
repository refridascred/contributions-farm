-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token, level, count) VALUES (59.35, 'staging', 7, 4);
INSERT INTO stats_logs (ratio, token, level, count) VALUES (33.68, 'standard', 98, 43);
INSERT INTO stats_logs (ratio, token, level, count) VALUES (49.87, 'edge', 56, 99);
