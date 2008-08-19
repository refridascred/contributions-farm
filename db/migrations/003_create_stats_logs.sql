-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, level, score) VALUES (25, 16, 51.22);
INSERT INTO stats_logs (count, level, score) VALUES (55, 12, 31.75);
INSERT INTO stats_logs (count, level, score) VALUES (42, 3, 16.57);
