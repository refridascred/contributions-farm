-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, active, count) VALUES ('strict', 41, 48, 83);
INSERT INTO stats_logs (region, level, active, count) VALUES ('blue', 79, 92, 77);
INSERT INTO stats_logs (region, level, active, count) VALUES ('latest', 31, 92, 34);
