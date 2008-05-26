-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, ratio, label, count) VALUES ('strict', 38.44, 'standard', 26);
INSERT INTO stats_logs (region, ratio, label, count) VALUES ('strict', 91.49, 'strict', 51);
INSERT INTO stats_logs (region, ratio, label, count) VALUES ('staging', 76.85, 'standard', 54);
