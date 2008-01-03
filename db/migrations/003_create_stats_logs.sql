-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, state, ratio, region) VALUES (45, 'staging', 76.85, 'legacy');
INSERT INTO stats_logs (active, state, ratio, region) VALUES (2, 'green', 66.17, 'strict');
INSERT INTO stats_logs (active, state, ratio, region) VALUES (47, 'latest', 58.05, 'eu-west');
