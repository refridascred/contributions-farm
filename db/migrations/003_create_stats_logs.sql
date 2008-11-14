-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, weight) VALUES (91, 27.25, 31.99);
INSERT INTO stats_logs (rank, ratio, weight) VALUES (35, 16.28, 28.25);
INSERT INTO stats_logs (rank, ratio, weight) VALUES (9, 42.51, 39.18);
