-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, owner, active, weight, region) VALUES (12, 'cached', 68, 38.77, 'eu-west');
INSERT INTO stats_logs (rank, owner, active, weight, region) VALUES (69, 'local', 25, 91.53, 'edge');
