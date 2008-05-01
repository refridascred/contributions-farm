-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, owner, region, count) VALUES (79.31, 'green', 'fallback', 10);
INSERT INTO stats_logs (ratio, owner, region, count) VALUES (21.06, 'stable', 'strict', 83);
INSERT INTO stats_logs (ratio, owner, region, count) VALUES (40.33, 'local', 'primary', 45);
