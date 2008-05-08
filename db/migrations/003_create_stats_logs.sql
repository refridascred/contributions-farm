-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, score, active, rank) VALUES ('eu-west', 0.42, 44, 52);
INSERT INTO stats_logs (token, score, active, rank) VALUES ('blue', 29.36, 64, 97);
INSERT INTO stats_logs (token, score, active, rank) VALUES ('cached', 9.02, 99, 49);
