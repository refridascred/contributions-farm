-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, count, ratio) VALUES ('blue', 94, 37.04);
INSERT INTO stats_logs (region, count, ratio) VALUES ('blue', 86, 91.49);
INSERT INTO stats_logs (region, count, ratio) VALUES ('staging', 65, 73.52);
