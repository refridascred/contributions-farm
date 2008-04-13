-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, score, label) VALUES (77.72, 47, 27.78, 'latest');
INSERT INTO stats_logs (weight, rank, score, label) VALUES (68.07, 33, 22.37, 'strict');
