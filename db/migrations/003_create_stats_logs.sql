-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, level, weight, owner, score) VALUES (79, 28, 56.08, 'open', 32.68);
INSERT INTO stats_logs (active, level, weight, owner, score) VALUES (49, 94, 83.88, 'cached', 67.24);
