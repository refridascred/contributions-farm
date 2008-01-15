-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, token, owner) VALUES (12, 'legacy', 'green');
INSERT INTO stats_logs (level, token, owner) VALUES (14, 'standard', 'strict');
