-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, token, ratio) VALUES (85, 'fallback', 84.57);
INSERT INTO stats_logs (active, token, ratio) VALUES (37, 'local', 61.11);
INSERT INTO stats_logs (active, token, ratio) VALUES (9, 'open', 89.62);
