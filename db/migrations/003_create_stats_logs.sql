-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, owner, region, weight) VALUES (20, 'eu-west', 'cached', 43.12);
INSERT INTO stats_logs (active, owner, region, weight) VALUES (7, 'green', 'fallback', 57.54);
INSERT INTO stats_logs (active, owner, region, weight) VALUES (58, 'standard', 'stable', 57.4);
