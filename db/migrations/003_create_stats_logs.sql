-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, rank) VALUES ('staging', 38);
INSERT INTO stats_logs (token, rank) VALUES ('edge', 30);
INSERT INTO stats_logs (token, rank) VALUES ('stable', 77);
