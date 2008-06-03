-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, ratio, weight, score) VALUES (93, 'standard', 39.98, 38.19, 24.24);
INSERT INTO stats_logs (level, label, ratio, weight, score) VALUES (71, 'legacy', 93.14, 14.83, 92.97);
