-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, token, level) VALUES (94, 'legacy', 40);
INSERT INTO stats_logs (active, token, level) VALUES (32, 'stable', 93);
INSERT INTO stats_logs (active, token, level) VALUES (90, 'local', 84);
