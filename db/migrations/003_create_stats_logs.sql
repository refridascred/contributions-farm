-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, weight, label) VALUES (81, 2.97, 'open');
INSERT INTO stats_logs (rank, weight, label) VALUES (55, 93.98, 'latest');
INSERT INTO stats_logs (rank, weight, label) VALUES (35, 94.11, 'primary');
