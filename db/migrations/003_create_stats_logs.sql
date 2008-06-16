-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, rank, weight) VALUES (50, 50.99, 35, 66.04);
INSERT INTO stats_logs (active, ratio, rank, weight) VALUES (18, 32.88, 40, 82.35);
INSERT INTO stats_logs (active, ratio, rank, weight) VALUES (53, 69.66, 7, 60.53);
