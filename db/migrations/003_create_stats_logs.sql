-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, region, owner, label) VALUES (79, 'staging', 'edge', 'strict');
INSERT INTO stats_logs (rank, region, owner, label) VALUES (60, 'local', 'eu-west', 'blue');
