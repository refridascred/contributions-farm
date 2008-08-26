-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, region, ratio, owner, weight) VALUES (1, 'standard', 10.15, 'standard', 98.92);
INSERT INTO stats_logs (active, region, ratio, owner, weight) VALUES (22, 'primary', 86.31, 'cached', 20.15);
