-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, label, rank, owner) VALUES ('legacy', 'local', 28, 'open');
INSERT INTO stats_logs (region, label, rank, owner) VALUES ('stable', 'edge', 61, 'local');
