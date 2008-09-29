-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, active) VALUES ('staging', 87);
INSERT INTO stats_logs (token, active) VALUES ('blue', 50);
INSERT INTO stats_logs (token, active) VALUES ('blue', 4);
