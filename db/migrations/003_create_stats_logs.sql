-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, score) VALUES ('cached', 34.43);
INSERT INTO stats_logs (token, score) VALUES ('blue', 90.7);
INSERT INTO stats_logs (token, score) VALUES ('stable', 82.76);
