-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, token, weight) VALUES (23, 'green', 25.32);
