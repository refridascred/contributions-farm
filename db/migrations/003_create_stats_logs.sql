-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, ratio, level) VALUES ('local', 3.67, 55);
INSERT INTO stats_logs (label, ratio, level) VALUES ('fallback', 8.08, 3);
INSERT INTO stats_logs (label, ratio, level) VALUES ('staging', 95.36, 52);
