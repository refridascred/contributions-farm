-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, owner, rank, ratio) VALUES (40.81, 'staging', 30, 58.69);
INSERT INTO stats_logs (weight, owner, rank, ratio) VALUES (49.82, 'strict', 70, 39.91);
INSERT INTO stats_logs (weight, owner, rank, ratio) VALUES (67.69, 'strict', 8, 97.03);
