-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, token, rank, score, active) VALUES ('standard', 'edge', 66, 37.66, 11);
INSERT INTO stats_logs (label, token, rank, score, active) VALUES ('latest', 'standard', 69, 8.3, 75);
INSERT INTO stats_logs (label, token, rank, score, active) VALUES ('legacy', 'primary', 19, 91.55, 14);
