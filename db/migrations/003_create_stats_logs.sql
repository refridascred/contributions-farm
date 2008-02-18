-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, ratio, label, count) VALUES (78, 63.17, 'staging', 50);
INSERT INTO stats_logs (level, ratio, label, count) VALUES (81, 17.8, 'local', 71);
INSERT INTO stats_logs (level, ratio, label, count) VALUES (88, 98.65, 'standard', 10);
