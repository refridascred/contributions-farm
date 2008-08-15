-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, rank) VALUES ('standard', 96);
INSERT INTO stats_logs (token, rank) VALUES ('local', 48);
INSERT INTO stats_logs (token, rank) VALUES ('staging', 12);
