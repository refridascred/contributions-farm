-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, ratio, score, active, count) VALUES ('standard', 65.48, 47.83, 29, 90);
INSERT INTO stats_logs (label, ratio, score, active, count) VALUES ('legacy', 95.32, 34.71, 18, 4);
INSERT INTO stats_logs (label, ratio, score, active, count) VALUES ('latest', 17.47, 40.82, 68, 51);
