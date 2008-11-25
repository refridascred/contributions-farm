-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, active, score) VALUES (28, 58.68, 14, 58.16);
INSERT INTO stats_logs (count, ratio, active, score) VALUES (48, 87.54, 82, 71.47);
INSERT INTO stats_logs (count, ratio, active, score) VALUES (61, 91.26, 52, 56.42);
