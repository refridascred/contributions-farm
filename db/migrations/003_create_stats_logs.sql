-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, owner, ratio, count) VALUES (48.46, 'green', 49.79, 11);
INSERT INTO stats_logs (weight, owner, ratio, count) VALUES (19.08, 'strict', 62.78, 63);
