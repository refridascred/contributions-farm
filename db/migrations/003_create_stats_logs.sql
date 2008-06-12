-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, region, active, owner) VALUES (99, 'fallback', 97, 'open');
INSERT INTO stats_logs (rank, region, active, owner) VALUES (53, 'blue', 36, 'fallback');
INSERT INTO stats_logs (rank, region, active, owner) VALUES (93, 'fallback', 97, 'edge');
