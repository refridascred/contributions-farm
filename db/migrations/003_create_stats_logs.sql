-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, count, ratio, level) VALUES (65, 99, 87.41, 71);
INSERT INTO stats_logs (active, count, ratio, level) VALUES (92, 34, 32.13, 22);
