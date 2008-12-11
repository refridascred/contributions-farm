-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, weight, active, count, score) VALUES ('primary', 88.56, 88, 84, 48.01);
INSERT INTO stats_logs (owner, weight, active, count, score) VALUES ('legacy', 79.69, 88, 89, 18.61);
