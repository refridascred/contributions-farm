-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, rank, score, count, active) VALUES ('open', 33, 22.91, 57, 11);
INSERT INTO stats_logs (token, rank, score, count, active) VALUES ('standard', 70, 24.94, 43, 34);
INSERT INTO stats_logs (token, rank, score, count, active) VALUES ('staging', 72, 38.03, 54, 51);
