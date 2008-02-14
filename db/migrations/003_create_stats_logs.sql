-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, count, weight, level) VALUES ('local', 62, 82.23, 74);
