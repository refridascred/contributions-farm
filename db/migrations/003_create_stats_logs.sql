-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, count, owner, weight) VALUES (8, 85, 'fallback', 39.78);
INSERT INTO stats_logs (rank, count, owner, weight) VALUES (90, 14, 'strict', 16.21);
INSERT INTO stats_logs (rank, count, owner, weight) VALUES (54, 84, 'fallback', 68.74);
