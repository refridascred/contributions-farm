-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, rank, weight, token) VALUES ('legacy', 94, 93.96, 'green');
INSERT INTO stats_logs (owner, rank, weight, token) VALUES ('local', 8, 50.97, 'eu-west');
