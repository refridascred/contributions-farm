-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, owner, level, active) VALUES (56.83, 'stable', 84, 45);
INSERT INTO stats_logs (score, owner, level, active) VALUES (30.22, 'cached', 99, 44);
INSERT INTO stats_logs (score, owner, level, active) VALUES (96.11, 'green', 46, 6);
