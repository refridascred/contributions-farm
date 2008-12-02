-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, label, weight) VALUES (73, 'green', 70.36);
INSERT INTO stats_logs (rank, label, weight) VALUES (10, 'legacy', 73.07);
INSERT INTO stats_logs (rank, label, weight) VALUES (43, 'primary', 10.82);
