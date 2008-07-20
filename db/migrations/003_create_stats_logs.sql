-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, score, count) VALUES (39.27, 6.82, 26);
INSERT INTO stats_logs (ratio, score, count) VALUES (9.6, 33.02, 74);
INSERT INTO stats_logs (ratio, score, count) VALUES (5.94, 30.27, 11);
