-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, label, score, active) VALUES (57.74, 'local', 39.95, 86);
INSERT INTO stats_logs (ratio, label, score, active) VALUES (96.9, 'stable', 57.35, 2);
INSERT INTO stats_logs (ratio, label, score, active) VALUES (25.4, 'stable', 47.32, 55);
