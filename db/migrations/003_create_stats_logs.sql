-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, owner, rank, ratio) VALUES ('green', 'strict', 79, 15.77);
