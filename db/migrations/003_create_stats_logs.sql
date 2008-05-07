-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, level, label) VALUES (27.14, 49, 'stable');
INSERT INTO stats_logs (ratio, level, label) VALUES (70.78, 61, 'primary');
INSERT INTO stats_logs (ratio, level, label) VALUES (98.57, 36, 'open');
