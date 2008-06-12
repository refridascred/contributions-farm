-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, owner, weight) VALUES (76.98, 'edge', 13.02);
INSERT INTO stats_logs (ratio, owner, weight) VALUES (11.29, 'standard', 87.75);
