-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, active, token) VALUES (47, 40, 'eu-west');
INSERT INTO stats_logs (level, active, token) VALUES (81, 25, 'stable');
INSERT INTO stats_logs (level, active, token) VALUES (7, 74, 'edge');
