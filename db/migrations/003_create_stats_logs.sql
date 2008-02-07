-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, score, token) VALUES (64, 85.52, 'edge');
INSERT INTO stats_logs (level, score, token) VALUES (62, 40.48, 'standard');
INSERT INTO stats_logs (level, score, token) VALUES (13, 85.76, 'standard');
