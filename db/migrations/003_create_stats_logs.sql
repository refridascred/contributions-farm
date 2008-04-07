-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, ratio, level, token) VALUES (87.94, 22.59, 99, 'edge');
INSERT INTO stats_logs (score, ratio, level, token) VALUES (95.9, 89.06, 44, 'primary');
