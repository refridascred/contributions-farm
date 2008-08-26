-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, level, weight) VALUES (63, 11, 51.37);
INSERT INTO stats_logs (count, level, weight) VALUES (0, 70, 28.25);
INSERT INTO stats_logs (count, level, weight) VALUES (14, 88, 90.41);
