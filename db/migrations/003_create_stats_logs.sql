-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, count, ratio, weight, label) VALUES (54, 90, 6.62, 91.91, 'strict');
INSERT INTO stats_logs (level, count, ratio, weight, label) VALUES (25, 71, 82.91, 60.41, 'strict');
