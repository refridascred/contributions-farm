-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, count, weight, region) VALUES ('blue', 65, 26.09, 'legacy');
INSERT INTO stats_logs (label, count, weight, region) VALUES ('open', 35, 26.27, 'strict');
INSERT INTO stats_logs (label, count, weight, region) VALUES ('stable', 25, 2.16, 'stable');
