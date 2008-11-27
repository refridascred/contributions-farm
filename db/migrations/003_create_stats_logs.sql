-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, rank, score, region) VALUES (18, 65, 74.37, 'strict');
INSERT INTO stats_logs (active, rank, score, region) VALUES (13, 55, 2.87, 'edge');
INSERT INTO stats_logs (active, rank, score, region) VALUES (60, 29, 60.74, 'green');
