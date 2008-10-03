-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, owner) VALUES (95.19, 16.7, 'strict');
INSERT INTO stats_logs (ratio, weight, owner) VALUES (96.79, 61.63, 'blue');
INSERT INTO stats_logs (ratio, weight, owner) VALUES (49.36, 59.4, 'blue');
