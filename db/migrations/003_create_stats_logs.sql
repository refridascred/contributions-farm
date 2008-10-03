-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, active, score) VALUES (43, 17.48, 36, 85.23);
INSERT INTO stats_logs (count, ratio, active, score) VALUES (36, 37.96, 75, 12.52);
INSERT INTO stats_logs (count, ratio, active, score) VALUES (23, 89.4, 62, 66.52);
