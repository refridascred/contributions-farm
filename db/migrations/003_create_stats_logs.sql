-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, ratio, token, level) VALUES (91, 75.22, 'standard', 87);
INSERT INTO stats_logs (active, ratio, token, level) VALUES (52, 29.43, 'staging', 72);
