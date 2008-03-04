-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, region, token, score) VALUES (73, 'edge', 'standard', 21.88);
INSERT INTO stats_logs (rank, region, token, score) VALUES (10, 'primary', 'staging', 59.0);
INSERT INTO stats_logs (rank, region, token, score) VALUES (89, 'staging', 'open', 32.97);
