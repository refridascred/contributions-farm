-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, score, label) VALUES (53, 67.44, 12.89, 'strict');
INSERT INTO stats_logs (active, ratio, score, label) VALUES (97, 32.78, 28.47, 'open');
INSERT INTO stats_logs (active, ratio, score, label) VALUES (84, 25.02, 88.95, 'stable');
