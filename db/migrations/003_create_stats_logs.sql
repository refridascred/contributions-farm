-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, count, token) VALUES (69, 60, 'fallback');
INSERT INTO stats_logs (level, count, token) VALUES (41, 19, 'standard');
INSERT INTO stats_logs (level, count, token) VALUES (27, 98, 'primary');
