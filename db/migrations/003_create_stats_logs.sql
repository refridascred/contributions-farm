-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, rank, weight) VALUES ('legacy', 27, 29.93);
INSERT INTO stats_logs (token, rank, weight) VALUES ('local', 84, 42.0);
INSERT INTO stats_logs (token, rank, weight) VALUES ('local', 18, 39.06);
