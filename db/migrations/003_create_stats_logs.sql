-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, active, region, label, owner) VALUES (17, 86, 'stable', 'stable', 'blue');
INSERT INTO stats_logs (rank, active, region, label, owner) VALUES (12, 65, 'open', 'local', 'eu-west');
INSERT INTO stats_logs (rank, active, region, label, owner) VALUES (63, 37, 'fallback', 'edge', 'blue');
