-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, active, level, score, ratio) VALUES ('edge', 74, 45, 95.85, 39.83);
INSERT INTO stats_logs (label, active, level, score, ratio) VALUES ('legacy', 39, 41, 48.37, 67.34);
INSERT INTO stats_logs (label, active, level, score, ratio) VALUES ('cached', 82, 12, 40.36, 41.93);
