-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, weight, region, active) VALUES (20, 10.59, 'cached', 61);
INSERT INTO stats_logs (count, weight, region, active) VALUES (25, 2.87, 'stable', 34);
INSERT INTO stats_logs (count, weight, region, active) VALUES (11, 72.53, 'legacy', 21);
