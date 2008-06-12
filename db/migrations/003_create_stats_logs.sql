-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, ratio, weight) VALUES (38, 20.54, 92.49);
INSERT INTO stats_logs (level, ratio, weight) VALUES (45, 69.88, 73.32);
INSERT INTO stats_logs (level, ratio, weight) VALUES (29, 68.0, 61.01);
