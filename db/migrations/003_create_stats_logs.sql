-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, ratio, level, count) VALUES ('staging', 7.25, 21, 95);
INSERT INTO stats_logs (region, ratio, level, count) VALUES ('open', 3.07, 60, 43);
INSERT INTO stats_logs (region, ratio, level, count) VALUES ('green', 94.36, 95, 98);
