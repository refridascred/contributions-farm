-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, count, level, ratio, label) VALUES (37.81, 29, 22, 93.15, 'edge');
INSERT INTO stats_logs (weight, count, level, ratio, label) VALUES (3.53, 89, 93, 89.75, 'legacy');
