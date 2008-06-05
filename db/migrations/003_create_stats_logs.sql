-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, ratio, count, level) VALUES (56.58, 89.15, 16, 34);
INSERT INTO stats_logs (score, ratio, count, level) VALUES (48.54, 32.77, 44, 43);
INSERT INTO stats_logs (score, ratio, count, level) VALUES (82.43, 36.63, 75, 24);
