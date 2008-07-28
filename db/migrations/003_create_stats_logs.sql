-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, score, token, level) VALUES (86.77, 32.91, 'edge', 19);
INSERT INTO stats_logs (ratio, score, token, level) VALUES (42.15, 73.93, 'local', 50);
