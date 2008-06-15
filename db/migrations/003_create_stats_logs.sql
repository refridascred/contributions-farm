-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, label, rank) VALUES (66.22, 'latest', 'strict', 30);
INSERT INTO stats_logs (ratio, region, label, rank) VALUES (17.33, 'green', 'cached', 31);
