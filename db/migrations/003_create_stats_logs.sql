-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, score) VALUES ('eu-west', 'latest', 68.7);
INSERT INTO stats_logs (region, token, score) VALUES ('blue', 'blue', 25.16);
