-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, active, weight, token, rank) VALUES (73.22, 75, 67.08, 'blue', 72);
INSERT INTO stats_logs (score, active, weight, token, rank) VALUES (21.5, 34, 22.54, 'blue', 69);
