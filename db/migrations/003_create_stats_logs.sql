-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, weight, ratio, token, owner) VALUES (58, 30.83, 44.82, 'staging', 'green');
INSERT INTO stats_logs (level, weight, ratio, token, owner) VALUES (77, 30.76, 88.09, 'edge', 'latest');
INSERT INTO stats_logs (level, weight, ratio, token, owner) VALUES (60, 84.7, 87.22, 'edge', 'edge');
