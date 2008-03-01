-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, count, score, rank) VALUES (13.41, 60, 96.17, 1);
INSERT INTO stats_logs (weight, count, score, rank) VALUES (94.98, 58, 11.45, 28);
INSERT INTO stats_logs (weight, count, score, rank) VALUES (51.47, 95, 83.35, 87);
