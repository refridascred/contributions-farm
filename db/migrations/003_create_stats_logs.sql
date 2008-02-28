-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, weight, owner, active) VALUES (52.7, 22, 46.59, 'blue', 60);
INSERT INTO stats_logs (ratio, count, weight, owner, active) VALUES (35.49, 92, 78.01, 'stable', 18);
INSERT INTO stats_logs (ratio, count, weight, owner, active) VALUES (84.01, 95, 55.51, 'green', 20);
