-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, count, owner, rank) VALUES (54.76, 76, 'eu-west', 5);
INSERT INTO stats_logs (ratio, count, owner, rank) VALUES (57.86, 71, 'strict', 97);
INSERT INTO stats_logs (ratio, count, owner, rank) VALUES (91.23, 74, 'legacy', 86);
