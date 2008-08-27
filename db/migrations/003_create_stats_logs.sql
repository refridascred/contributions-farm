-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (ratio, count, score, active) VALUES (19.77, 80, 84.31, 38);
INSERT INTO stats_logs (ratio, count, score, active) VALUES (88.81, 24, 21.57, 94);
INSERT INTO stats_logs (ratio, count, score, active) VALUES (62.1, 50, 83.82, 68);
