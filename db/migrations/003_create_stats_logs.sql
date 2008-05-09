-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, count, active) VALUES ('blue', 76.67, 14, 13);
INSERT INTO stats_logs (owner, ratio, count, active) VALUES ('edge', 29.85, 7, 4);
INSERT INTO stats_logs (owner, ratio, count, active) VALUES ('strict', 42.34, 35, 61);
