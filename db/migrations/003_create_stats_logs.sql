-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, owner, token) VALUES (31, 'local', 'primary');
INSERT INTO stats_logs (rank, owner, token) VALUES (7, 'staging', 'eu-west');
