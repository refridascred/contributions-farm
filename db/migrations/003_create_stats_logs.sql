-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, score, weight) VALUES (11, 35.82, 30.53);
INSERT INTO stats_logs (rank, score, weight) VALUES (55, 18.67, 84.54);
INSERT INTO stats_logs (rank, score, weight) VALUES (19, 68.37, 62.74);
