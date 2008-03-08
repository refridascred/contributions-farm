-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, count, rank) VALUES (92.06, 74, 39);
INSERT INTO stats_logs (weight, count, rank) VALUES (71.96, 78, 39);
INSERT INTO stats_logs (weight, count, rank) VALUES (29.1, 43, 47);
