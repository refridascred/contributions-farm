-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (weight, level, active, token, label) VALUES (1.57, 73, 19, 'open', 'fallback');
INSERT INTO stats_logs (weight, level, active, token, label) VALUES (74.6, 56, 4, 'latest', 'latest');
