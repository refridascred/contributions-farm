-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, count, score) VALUES ('staging', 44, 80.27);
INSERT INTO stats_logs (token, count, score) VALUES ('stable', 87, 12.59);
INSERT INTO stats_logs (token, count, score) VALUES ('local', 48, 60.82);
