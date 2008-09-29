-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, count, score) VALUES (93, 1, 83.13);
INSERT INTO stats_logs (level, count, score) VALUES (60, 27, 83.61);
INSERT INTO stats_logs (level, count, score) VALUES (17, 7, 17.39);
