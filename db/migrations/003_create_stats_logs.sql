-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, token) VALUES (68.19, 37, 'eu-west');
INSERT INTO stats_logs (weight, rank, token) VALUES (25.56, 53, 'local');
INSERT INTO stats_logs (weight, rank, token) VALUES (30.65, 71, 'stable');
