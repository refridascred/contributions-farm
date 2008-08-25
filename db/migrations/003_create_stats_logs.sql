-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, rank, level) VALUES ('staging', 39, 9);
INSERT INTO stats_logs (label, rank, level) VALUES ('local', 16, 68);
INSERT INTO stats_logs (label, rank, level) VALUES ('blue', 39, 42);
