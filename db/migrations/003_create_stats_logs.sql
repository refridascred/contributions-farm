-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, token, region) VALUES (29.14, 41, 'standard', 'primary');
INSERT INTO stats_logs (score, level, token, region) VALUES (56.94, 62, 'edge', 'stable');
INSERT INTO stats_logs (score, level, token, region) VALUES (14.84, 74, 'latest', 'edge');
