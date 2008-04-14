-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, score, owner, region, weight) VALUES (16, 37.24, 'open', 'eu-west', 39.4);
INSERT INTO stats_logs (active, score, owner, region, weight) VALUES (4, 7.63, 'staging', 'legacy', 90.47);
INSERT INTO stats_logs (active, score, owner, region, weight) VALUES (12, 53.75, 'standard', 'eu-west', 22.08);
