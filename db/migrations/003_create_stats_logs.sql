-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, region, weight, state, label) VALUES (20, 'legacy', 13.21, 'cached', 'blue');
INSERT INTO stats_logs (active, region, weight, state, label) VALUES (32, 'latest', 98.57, 'green', 'cached');
