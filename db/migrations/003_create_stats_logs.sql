-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, weight) VALUES (47, 85.72);
INSERT INTO stats_logs (level, weight) VALUES (30, 80.98);
INSERT INTO stats_logs (level, weight) VALUES (19, 56.71);
