-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, label, owner) VALUES (4, 'local', 'strict');
INSERT INTO stats_logs (rank, label, owner) VALUES (46, 'edge', 'blue');
INSERT INTO stats_logs (rank, label, owner) VALUES (5, 'staging', 'latest');
