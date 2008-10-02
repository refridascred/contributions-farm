-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, region, label, rank, count) VALUES (0.08, 'strict', 'blue', 45, 23);
INSERT INTO stats_logs (weight, region, label, rank, count) VALUES (30.12, 'green', 'legacy', 34, 9);
INSERT INTO stats_logs (weight, region, label, rank, count) VALUES (62.8, 'primary', 'cached', 47, 57);
