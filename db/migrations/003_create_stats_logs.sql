-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, region, score, weight) VALUES ('legacy', 'legacy', 62.62, 7.54);
INSERT INTO stats_logs (owner, region, score, weight) VALUES ('primary', 'primary', 64.53, 40.99);
INSERT INTO stats_logs (owner, region, score, weight) VALUES ('stable', 'staging', 77.79, 3.32);
