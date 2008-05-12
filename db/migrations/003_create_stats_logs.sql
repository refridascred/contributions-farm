-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, level, weight, owner) VALUES (89.87, 89, 19.14, 'cached');
INSERT INTO stats_logs (ratio, level, weight, owner) VALUES (14.74, 23, 3.22, 'local');
INSERT INTO stats_logs (ratio, level, weight, owner) VALUES (33.61, 37, 50.02, 'legacy');
