-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, region, token) VALUES (80, 'eu-west', 'primary', 'staging');
INSERT INTO stats_logs (rank, owner, region, token) VALUES (55, 'edge', 'latest', 'standard');
INSERT INTO stats_logs (rank, owner, region, token) VALUES (47, 'blue', 'latest', 'staging');
