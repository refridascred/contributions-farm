-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, rank, label, level) VALUES (38.93, 79, 'cached', 17);
INSERT INTO stats_logs (weight, rank, label, level) VALUES (39.05, 57, 'staging', 3);
