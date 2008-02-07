-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, weight, active) VALUES (59.57, 'open', 77.34, 66);
INSERT INTO stats_logs (ratio, region, weight, active) VALUES (0.06, 'open', 74.33, 42);
