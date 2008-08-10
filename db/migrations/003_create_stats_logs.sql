-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, ratio, token) VALUES (53, 83.85, 'fallback');
INSERT INTO stats_logs (level, ratio, token) VALUES (46, 30.06, 'local');
INSERT INTO stats_logs (level, ratio, token) VALUES (51, 17.02, 'staging');
