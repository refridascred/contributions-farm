-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, region) VALUES (62, 'open', 'fallback');
INSERT INTO stats_logs (rank, owner, region) VALUES (44, 'open', 'blue');
INSERT INTO stats_logs (rank, owner, region) VALUES (23, 'eu-west', 'primary');
