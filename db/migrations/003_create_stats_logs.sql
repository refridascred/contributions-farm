-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, owner, region) VALUES (36, 'strict', 'primary', 'local');
INSERT INTO stats_logs (rank, token, owner, region) VALUES (14, 'blue', 'standard', 'cached');
