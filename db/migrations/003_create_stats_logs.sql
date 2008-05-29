-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, count, token, score) VALUES (5, 75, 'fallback', 83.35);
INSERT INTO stats_logs (level, count, token, score) VALUES (40, 81, 'staging', 97.88);
INSERT INTO stats_logs (level, count, token, score) VALUES (81, 78, 'strict', 71.2);
