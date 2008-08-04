-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, count) VALUES ('cached', 17.9, 91);
INSERT INTO stats_logs (region, weight, count) VALUES ('open', 47.21, 98);
INSERT INTO stats_logs (region, weight, count) VALUES ('local', 24.54, 84);
