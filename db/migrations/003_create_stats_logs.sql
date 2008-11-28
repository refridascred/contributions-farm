-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, ratio, weight, count, state) VALUES (2, 43.73, 57.02, 30, 'eu-west');
INSERT INTO stats_logs (level, ratio, weight, count, state) VALUES (91, 26.3, 66.06, 46, 'cached');
INSERT INTO stats_logs (level, ratio, weight, count, state) VALUES (15, 45.05, 21.05, 78, 'latest');
