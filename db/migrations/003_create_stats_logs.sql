-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank, ratio, count) VALUES ('strict', 60, 58.63, 90);
INSERT INTO stats_logs (region, rank, ratio, count) VALUES ('fallback', 28, 37.86, 54);
INSERT INTO stats_logs (region, rank, ratio, count) VALUES ('green', 94, 65.97, 50);
