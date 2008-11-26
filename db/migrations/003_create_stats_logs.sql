-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, owner) VALUES ('open', 'open');
INSERT INTO stats_logs (token, owner) VALUES ('staging', 'open');
INSERT INTO stats_logs (token, owner) VALUES ('staging', 'local');
