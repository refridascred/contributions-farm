-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, owner) VALUES (14, 'stable');
INSERT INTO stats_logs (rank, owner) VALUES (65, 'local');
INSERT INTO stats_logs (rank, owner) VALUES (82, 'latest');
