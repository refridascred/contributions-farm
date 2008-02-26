-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, ratio, label) VALUES (69, 32.27, 'strict');
INSERT INTO stats_logs (level, ratio, label) VALUES (34, 51.99, 'edge');
