-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, count, region, level) VALUES (71, 80, 'staging', 36);
INSERT INTO stats_logs (active, count, region, level) VALUES (0, 6, 'latest', 95);
INSERT INTO stats_logs (active, count, region, level) VALUES (90, 59, 'green', 2);
