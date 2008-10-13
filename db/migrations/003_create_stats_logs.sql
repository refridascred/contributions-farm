-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, label, level) VALUES (89.41, 'primary', 28);
INSERT INTO stats_logs (ratio, label, level) VALUES (42.96, 'edge', 89);
INSERT INTO stats_logs (ratio, label, level) VALUES (45.5, 'edge', 76);
