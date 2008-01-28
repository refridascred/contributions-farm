-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, ratio, label, region, owner) VALUES (58, 12.65, 'edge', 'green', 'primary');
INSERT INTO stats_logs (level, ratio, label, region, owner) VALUES (28, 31.61, 'staging', 'primary', 'standard');
INSERT INTO stats_logs (level, ratio, label, region, owner) VALUES (38, 81.1, 'primary', 'green', 'staging');
