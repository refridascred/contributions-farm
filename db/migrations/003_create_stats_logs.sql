-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, label, active, region, owner) VALUES (2, 'strict', 11, 'primary', 'edge');
INSERT INTO stats_logs (rank, label, active, region, owner) VALUES (90, 'cached', 16, 'open', 'open');
