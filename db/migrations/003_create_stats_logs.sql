-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, state, region, count, ratio) VALUES (43, 'green', 'standard', 24, 87.11);
INSERT INTO stats_logs (active, state, region, count, ratio) VALUES (16, 'eu-west', 'eu-west', 15, 75.95);
INSERT INTO stats_logs (active, state, region, count, ratio) VALUES (66, 'eu-west', 'strict', 76, 78.51);
