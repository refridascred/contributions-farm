-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, ratio, count, weight) VALUES ('legacy', 24.59, 42, 8.15);
INSERT INTO stats_logs (owner, ratio, count, weight) VALUES ('local', 16.23, 92, 7.33);
INSERT INTO stats_logs (owner, ratio, count, weight) VALUES ('blue', 10.85, 85, 26.29);
