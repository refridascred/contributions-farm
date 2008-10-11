-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, weight, region, score, ratio) VALUES (39, 27.3, 'staging', 66.82, 42.13);
INSERT INTO stats_logs (count, weight, region, score, ratio) VALUES (81, 11.49, 'cached', 83.75, 22.27);
