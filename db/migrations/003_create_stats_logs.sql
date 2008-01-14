-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, token) VALUES (43, 'green');
INSERT INTO stats_logs (level, token) VALUES (64, 'strict');
INSERT INTO stats_logs (level, token) VALUES (17, 'primary');
