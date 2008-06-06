-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, owner, weight, token) VALUES (17, 'cached', 68.67, 'cached');
INSERT INTO stats_logs (active, owner, weight, token) VALUES (8, 'fallback', 80.78, 'open');
