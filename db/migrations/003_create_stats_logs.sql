-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, ratio, score, count, active) VALUES ('staging', 90.93, 96.59, 17, 85);
INSERT INTO stats_logs (label, ratio, score, count, active) VALUES ('latest', 88.07, 75.87, 24, 27);
INSERT INTO stats_logs (label, ratio, score, count, active) VALUES ('local', 70.92, 29.61, 80, 71);
