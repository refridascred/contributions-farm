-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (level, count, rank, weight) VALUES (6, 75, 74, 15.02);
INSERT INTO stats_logs (level, count, rank, weight) VALUES (75, 80, 44, 98.94);
INSERT INTO stats_logs (level, count, rank, weight) VALUES (83, 14, 56, 24.84);
