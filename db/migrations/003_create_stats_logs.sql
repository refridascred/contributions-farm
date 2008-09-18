-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, region, owner, label, weight) VALUES (43, 'staging', 'primary', 'legacy', 11.41);
INSERT INTO stats_logs (active, region, owner, label, weight) VALUES (36, 'legacy', 'green', 'primary', 40.88);
