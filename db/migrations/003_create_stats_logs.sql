-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, owner, token, level, active) VALUES (12, 'cached', 'latest', 41, 54);
INSERT INTO stats_logs (count, owner, token, level, active) VALUES (65, 'open', 'standard', 74, 26);
INSERT INTO stats_logs (count, owner, token, level, active) VALUES (71, 'stable', 'edge', 45, 14);
