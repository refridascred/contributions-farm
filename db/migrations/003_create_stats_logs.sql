-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, active, ratio) VALUES (16.04, 72, 30.63);
INSERT INTO stats_logs (weight, active, ratio) VALUES (47.99, 79, 58.4);
INSERT INTO stats_logs (weight, active, ratio) VALUES (55.71, 2, 87.6);
