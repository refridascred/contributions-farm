-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, ratio, region) VALUES (66.57, 46.46, 'primary');
INSERT INTO stats_logs (score, ratio, region) VALUES (53.77, 83.75, 'legacy');
INSERT INTO stats_logs (score, ratio, region) VALUES (21.7, 86.55, 'staging');
