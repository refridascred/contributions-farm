-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, region, weight, score) VALUES (70, 'local', 26.83, 98.03);
INSERT INTO stats_logs (rank, region, weight, score) VALUES (23, 'eu-west', 77.3, 21.09);
INSERT INTO stats_logs (rank, region, weight, score) VALUES (97, 'eu-west', 73.77, 31.6);
