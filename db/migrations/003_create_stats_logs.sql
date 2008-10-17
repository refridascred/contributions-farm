-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, active, owner) VALUES (90, 79, 'blue');
INSERT INTO stats_logs (level, active, owner) VALUES (86, 6, 'stable');
INSERT INTO stats_logs (level, active, owner) VALUES (72, 90, 'edge');
