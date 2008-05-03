-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, weight, ratio) VALUES (68, 57.23, 54.21);
INSERT INTO stats_logs (count, weight, ratio) VALUES (23, 78.22, 27.36);
