-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, count, score) VALUES ('primary', 73, 31, 46.61);
INSERT INTO stats_logs (token, level, count, score) VALUES ('green', 91, 34, 79.62);
INSERT INTO stats_logs (token, level, count, score) VALUES ('standard', 65, 1, 14.07);
