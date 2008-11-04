-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, ratio, label, level, count) VALUES ('open', 87.45, 'edge', 55, 17);
INSERT INTO stats_logs (region, ratio, label, level, count) VALUES ('primary', 57.05, 'strict', 61, 15);
