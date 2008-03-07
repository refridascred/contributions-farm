-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, active, region, weight, count) VALUES ('stable', 37, 'cached', 45.25, 39);
INSERT INTO stats_logs (label, active, region, weight, count) VALUES ('stable', 58, 'stable', 69.55, 81);
INSERT INTO stats_logs (label, active, region, weight, count) VALUES ('legacy', 33, 'legacy', 85.06, 62);
