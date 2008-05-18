-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, state, rank, active, region) VALUES (59.7, 'staging', 20, 29, 'edge');
INSERT INTO stats_logs (weight, state, rank, active, region) VALUES (59.31, 'legacy', 71, 15, 'eu-west');
