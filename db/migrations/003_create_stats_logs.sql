-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, active, rank, level) VALUES (42.53, 61, 11, 69);
INSERT INTO stats_logs (weight, active, rank, level) VALUES (88.59, 99, 41, 93);
INSERT INTO stats_logs (weight, active, rank, level) VALUES (90.02, 54, 79, 21);
