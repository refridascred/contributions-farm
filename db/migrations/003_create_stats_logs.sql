-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, level) VALUES (51, 69);
INSERT INTO stats_logs (rank, level) VALUES (55, 4);
INSERT INTO stats_logs (rank, level) VALUES (14, 11);
