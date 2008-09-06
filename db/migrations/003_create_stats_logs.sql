-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, owner, active, level, ratio) VALUES ('edge', 'blue', 47, 40, 55.27);
INSERT INTO stats_logs (token, owner, active, level, ratio) VALUES ('standard', 'edge', 76, 53, 43.76);
