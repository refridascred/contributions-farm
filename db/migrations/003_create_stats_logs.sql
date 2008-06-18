-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, count, token) VALUES (28, 4, 'standard');
INSERT INTO stats_logs (level, count, token) VALUES (95, 79, 'green');
INSERT INTO stats_logs (level, count, token) VALUES (3, 90, 'standard');
