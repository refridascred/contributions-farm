-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, active, token, weight) VALUES (29, 94, 'blue', 14.77);
INSERT INTO stats_logs (rank, active, token, weight) VALUES (19, 45, 'strict', 2.21);
INSERT INTO stats_logs (rank, active, token, weight) VALUES (94, 4, 'local', 76.88);
