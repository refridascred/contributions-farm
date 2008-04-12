-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, score) VALUES ('standard', 53.99);
INSERT INTO stats_logs (region, score) VALUES ('local', 83.17);
INSERT INTO stats_logs (region, score) VALUES ('standard', 73.24);
