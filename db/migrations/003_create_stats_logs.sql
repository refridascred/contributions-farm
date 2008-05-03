-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, label, rank) VALUES (68.65, 'primary', 40);
INSERT INTO stats_logs (ratio, label, rank) VALUES (6.53, 'latest', 7);
INSERT INTO stats_logs (ratio, label, rank) VALUES (17.14, 'primary', 7);
