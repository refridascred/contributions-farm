-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, label, owner) VALUES (9, 'cached', 'staging');
INSERT INTO stats_logs (rank, label, owner) VALUES (61, 'stable', 'edge');
INSERT INTO stats_logs (rank, label, owner) VALUES (6, 'staging', 'eu-west');
