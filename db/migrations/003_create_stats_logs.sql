-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, active, rank, region) VALUES ('staging', 12, 49, 'edge');
INSERT INTO stats_logs (owner, active, rank, region) VALUES ('legacy', 12, 37, 'latest');
INSERT INTO stats_logs (owner, active, rank, region) VALUES ('blue', 71, 4, 'edge');
