-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, ratio, score, count) VALUES (32, 47.02, 41.68, 91);
INSERT INTO stats_logs (active, ratio, score, count) VALUES (57, 55.49, 20.94, 33);
INSERT INTO stats_logs (active, ratio, score, count) VALUES (73, 80.27, 50.15, 7);
