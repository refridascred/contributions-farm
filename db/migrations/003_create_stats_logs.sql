-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, state, count, weight, region) VALUES (40, 'eu-west', 19, 87.39, 'strict');
INSERT INTO stats_logs (active, state, count, weight, region) VALUES (75, 'stable', 12, 89.16, 'cached');
INSERT INTO stats_logs (active, state, count, weight, region) VALUES (90, 'edge', 88, 36.81, 'staging');
