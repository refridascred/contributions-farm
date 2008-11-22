-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, ratio, state, active, count) VALUES ('stable', 36.03, 'green', 22, 46);
INSERT INTO stats_logs (region, ratio, state, active, count) VALUES ('green', 0.48, 'edge', 51, 13);
INSERT INTO stats_logs (region, ratio, state, active, count) VALUES ('fallback', 59.03, 'blue', 38, 10);
