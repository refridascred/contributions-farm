-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, region, rank, ratio) VALUES ('fallback', 'green', 63, 63.61);
INSERT INTO stats_logs (owner, region, rank, ratio) VALUES ('standard', 'green', 88, 26.85);
