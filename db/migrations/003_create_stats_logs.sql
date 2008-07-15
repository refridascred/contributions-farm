-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, level, ratio) VALUES ('edge', 59, 68, 40.98);
INSERT INTO stats_logs (label, rank, level, ratio) VALUES ('fallback', 1, 74, 36.14);
INSERT INTO stats_logs (label, rank, level, ratio) VALUES ('primary', 3, 47, 89.82);
