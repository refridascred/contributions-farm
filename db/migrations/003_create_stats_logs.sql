-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, level, rank, weight) VALUES (39.62, 65, 34, 46, 25.47);
INSERT INTO stats_logs (ratio, count, level, rank, weight) VALUES (37.69, 25, 35, 21, 26.55);
INSERT INTO stats_logs (ratio, count, level, rank, weight) VALUES (68.35, 29, 41, 70, 20.98);
