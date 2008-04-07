-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, count, ratio, rank) VALUES ('fallback', 31, 11.99, 41);
INSERT INTO stats_logs (owner, count, ratio, rank) VALUES ('strict', 59, 90.77, 8);
INSERT INTO stats_logs (owner, count, ratio, rank) VALUES ('eu-west', 35, 87.85, 58);
