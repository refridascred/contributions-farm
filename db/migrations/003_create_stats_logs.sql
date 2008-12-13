-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, count, weight, level, ratio) VALUES (78, 1, 78.93, 65, 46.38);
INSERT INTO stats_logs (active, count, weight, level, ratio) VALUES (38, 70, 97.86, 42, 50.08);
