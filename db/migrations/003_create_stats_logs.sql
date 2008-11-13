-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, count) VALUES ('open', 31);
INSERT INTO stats_logs (token, count) VALUES ('strict', 30);
INSERT INTO stats_logs (token, count) VALUES ('standard', 25);
