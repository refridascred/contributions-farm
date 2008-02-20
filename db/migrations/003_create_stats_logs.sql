-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, rank, active) VALUES (57.35, 17, 1);
INSERT INTO stats_logs (score, rank, active) VALUES (19.5, 7, 8);
INSERT INTO stats_logs (score, rank, active) VALUES (77.05, 23, 67);
