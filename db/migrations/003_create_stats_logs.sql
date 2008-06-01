-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, label, region, score, token) VALUES (5, 'edge', 'open', 55.97, 'fallback');
INSERT INTO stats_logs (level, label, region, score, token) VALUES (62, 'legacy', 'latest', 67.07, 'latest');
