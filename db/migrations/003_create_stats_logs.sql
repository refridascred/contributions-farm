-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, level, score, owner, weight) VALUES (10, 78, 24.21, 'edge', 45.91);
INSERT INTO stats_logs (active, level, score, owner, weight) VALUES (1, 32, 72.4, 'fallback', 46.4);
