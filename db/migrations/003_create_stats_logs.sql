-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, weight, level, count) VALUES ('eu-west', 71.05, 54, 84);
INSERT INTO stats_logs (region, weight, level, count) VALUES ('primary', 6.73, 5, 77);
INSERT INTO stats_logs (region, weight, level, count) VALUES ('edge', 85.13, 85, 28);
