-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, label, region, active, rank) VALUES (8.38, 'local', 'latest', 27, 41);
INSERT INTO stats_logs (score, label, region, active, rank) VALUES (6.84, 'strict', 'green', 87, 71);
