-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, level, weight, label, score) VALUES (53.45, 82, 21.64, 'stable', 86.22);
INSERT INTO stats_logs (ratio, level, weight, label, score) VALUES (97.09, 31, 76.19, 'latest', 67.18);
INSERT INTO stats_logs (ratio, level, weight, label, score) VALUES (80.59, 50, 30.67, 'eu-west', 77.5);
