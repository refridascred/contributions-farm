-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, count, score, active) VALUES (2.99, 31, 20.33, 46);
INSERT INTO stats_logs (weight, count, score, active) VALUES (77.91, 71, 29.96, 34);
INSERT INTO stats_logs (weight, count, score, active) VALUES (59.06, 75, 3.68, 40);
