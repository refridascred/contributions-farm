-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, score, rank, weight, active) VALUES ('staging', 2.29, 13, 87.65, 25);
INSERT INTO stats_logs (label, score, rank, weight, active) VALUES ('primary', 14.83, 65, 95.89, 1);
INSERT INTO stats_logs (label, score, rank, weight, active) VALUES ('latest', 87.56, 67, 60.24, 16);
