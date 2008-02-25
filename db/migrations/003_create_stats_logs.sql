-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, rank, weight, region) VALUES ('staging', 69, 37.16, 'eu-west');
INSERT INTO stats_logs (owner, rank, weight, region) VALUES ('legacy', 60, 36.27, 'green');
INSERT INTO stats_logs (owner, rank, weight, region) VALUES ('latest', 70, 76.79, 'edge');
