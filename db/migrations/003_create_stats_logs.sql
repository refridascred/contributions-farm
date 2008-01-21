-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, weight, ratio) VALUES (41, 82.53, 51.09);
INSERT INTO stats_logs (count, weight, ratio) VALUES (31, 31.35, 87.04);
INSERT INTO stats_logs (count, weight, ratio) VALUES (82, 78.78, 23.66);
