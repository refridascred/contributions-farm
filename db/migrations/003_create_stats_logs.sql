-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, weight, ratio, count, level) VALUES (41, 9.62, 32.96, 54, 53);
INSERT INTO stats_logs (rank, weight, ratio, count, level) VALUES (71, 4.75, 66.89, 51, 3);
