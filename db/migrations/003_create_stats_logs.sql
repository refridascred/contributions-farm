-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, level, token) VALUES (96, 97, 'latest');
INSERT INTO stats_logs (active, level, token) VALUES (83, 66, 'fallback');
INSERT INTO stats_logs (active, level, token) VALUES (88, 37, 'stable');
