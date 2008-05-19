-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, count, weight, ratio) VALUES ('cached', 68, 83.69, 55.22);
INSERT INTO stats_logs (owner, count, weight, ratio) VALUES ('green', 36, 42.31, 8.26);
