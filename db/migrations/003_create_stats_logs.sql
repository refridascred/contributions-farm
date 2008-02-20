-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, weight, count) VALUES (52, 7.27, 78);
INSERT INTO stats_logs (level, weight, count) VALUES (71, 91.19, 38);
INSERT INTO stats_logs (level, weight, count) VALUES (3, 73.68, 45);
