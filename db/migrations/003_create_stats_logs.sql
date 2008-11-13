-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, owner, ratio, level, weight) VALUES (86, 'fallback', 46.19, 27, 70.82);
INSERT INTO stats_logs (count, owner, ratio, level, weight) VALUES (28, 'strict', 42.03, 91, 62.11);
INSERT INTO stats_logs (count, owner, ratio, level, weight) VALUES (40, 'strict', 97.41, 69, 6.48);
