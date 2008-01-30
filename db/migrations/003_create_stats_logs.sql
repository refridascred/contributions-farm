-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, level, token, count, owner) VALUES (43, 16, 'standard', 26, 'fallback');
INSERT INTO stats_logs (active, level, token, count, owner) VALUES (89, 51, 'fallback', 60, 'edge');
