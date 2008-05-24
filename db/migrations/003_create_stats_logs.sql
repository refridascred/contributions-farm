-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, score, ratio) VALUES (31, 78.34, 14.14);
INSERT INTO stats_logs (count, score, ratio) VALUES (42, 8.91, 94.64);
INSERT INTO stats_logs (count, score, ratio) VALUES (55, 38.2, 73.42);
