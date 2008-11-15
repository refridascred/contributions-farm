-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    token TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, label, token, level, rank) VALUES (75.85, 'staging', 'staging', 67, 34);
INSERT INTO stats_logs (weight, label, token, level, rank) VALUES (1.7, 'strict', 'stable', 20, 46);
