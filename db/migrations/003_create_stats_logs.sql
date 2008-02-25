-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, ratio, weight) VALUES (54, 82.67, 62.02);
INSERT INTO stats_logs (level, ratio, weight) VALUES (17, 2.78, 88.37);
INSERT INTO stats_logs (level, ratio, weight) VALUES (12, 24.32, 54.2);
