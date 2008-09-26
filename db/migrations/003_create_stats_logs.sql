-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, level, count, token) VALUES ('cached', 57, 93, 'latest');
INSERT INTO stats_logs (region, level, count, token) VALUES ('local', 41, 59, 'cached');
INSERT INTO stats_logs (region, level, count, token) VALUES ('edge', 71, 74, 'green');
