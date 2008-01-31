-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, region, ratio, label) VALUES (57, 'stable', 9.57, 'open');
INSERT INTO stats_logs (level, region, ratio, label) VALUES (66, 'cached', 58.42, 'standard');
INSERT INTO stats_logs (level, region, ratio, label) VALUES (52, 'legacy', 75.66, 'eu-west');
