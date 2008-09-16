-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, ratio, score, region, label) VALUES (19, 26.7, 88.1, 'local', 'staging');
INSERT INTO stats_logs (level, ratio, score, region, label) VALUES (89, 77.2, 4.94, 'primary', 'stable');
