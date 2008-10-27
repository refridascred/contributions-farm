-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, token, weight, ratio) VALUES (17, 'blue', 13.36, 8.85);
INSERT INTO stats_logs (count, token, weight, ratio) VALUES (3, 'edge', 50.51, 7.33);
