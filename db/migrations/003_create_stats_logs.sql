-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, level, count, rank, weight) VALUES (65.64, 51, 71, 55, 66.39);
INSERT INTO stats_logs (ratio, level, count, rank, weight) VALUES (46.41, 12, 5, 89, 68.42);
INSERT INTO stats_logs (ratio, level, count, rank, weight) VALUES (78.75, 84, 89, 27, 91.34);
