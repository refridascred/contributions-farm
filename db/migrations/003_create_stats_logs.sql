-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, region, active, score) VALUES (37.45, 'cached', 54, 85.48);
INSERT INTO stats_logs (weight, region, active, score) VALUES (21.28, 'staging', 50, 79.52);
INSERT INTO stats_logs (weight, region, active, score) VALUES (70.48, 'fallback', 99, 69.37);
