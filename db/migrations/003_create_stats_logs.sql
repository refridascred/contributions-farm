-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, count, level, rank) VALUES (84.28, 70, 59, 87);
INSERT INTO stats_logs (score, count, level, rank) VALUES (75.94, 13, 52, 41);
INSERT INTO stats_logs (score, count, level, rank) VALUES (68.51, 1, 6, 8);
