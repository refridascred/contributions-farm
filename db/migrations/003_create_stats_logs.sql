-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, count, score) VALUES (0, 56, 8.97);
INSERT INTO stats_logs (level, count, score) VALUES (27, 24, 18.56);
INSERT INTO stats_logs (level, count, score) VALUES (0, 44, 89.07);
