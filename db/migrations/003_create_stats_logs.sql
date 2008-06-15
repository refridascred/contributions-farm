-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (score, ratio, label, level, active) VALUES (14.09, 97.73, 'primary', 43, 97);
