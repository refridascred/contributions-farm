-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, active, score, region) VALUES (43, 'staging', 38, 93.81, 'legacy');
INSERT INTO stats_logs (rank, owner, active, score, region) VALUES (83, 'edge', 46, 73.19, 'eu-west');
