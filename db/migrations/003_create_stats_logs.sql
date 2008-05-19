-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, rank) VALUES (53, 51.24, 27);
INSERT INTO stats_logs (count, ratio, rank) VALUES (96, 30.91, 63);
INSERT INTO stats_logs (count, ratio, rank) VALUES (53, 15.09, 64);
