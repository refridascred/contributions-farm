-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, count, weight, state) VALUES ('primary', 89, 1.9, 'latest');
INSERT INTO stats_logs (token, count, weight, state) VALUES ('standard', 88, 77.46, 'blue');
INSERT INTO stats_logs (token, count, weight, state) VALUES ('edge', 34, 7.98, 'edge');
