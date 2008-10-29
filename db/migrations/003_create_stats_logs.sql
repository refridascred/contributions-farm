-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, score, active, weight) VALUES (94, 11.43, 28, 60.37);
INSERT INTO stats_logs (rank, score, active, weight) VALUES (74, 26.09, 89, 26.01);
