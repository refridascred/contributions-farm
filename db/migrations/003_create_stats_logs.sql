-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, level, active) VALUES (34, 99, 47);
INSERT INTO stats_logs (rank, level, active) VALUES (9, 60, 56);
INSERT INTO stats_logs (rank, level, active) VALUES (23, 27, 72);
