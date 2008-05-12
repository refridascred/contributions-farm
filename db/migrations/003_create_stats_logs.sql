-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, level, token) VALUES (85.77, 51, 'primary');
INSERT INTO stats_logs (score, level, token) VALUES (83.44, 93, 'legacy');
INSERT INTO stats_logs (score, level, token) VALUES (34.54, 15, 'latest');
