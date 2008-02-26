-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (label, count, weight, score, owner) VALUES ('edge', 92, 19.85, 34.1, 'blue');
INSERT INTO stats_logs (label, count, weight, score, owner) VALUES ('strict', 81, 69.69, 29.28, 'strict');
INSERT INTO stats_logs (label, count, weight, score, owner) VALUES ('legacy', 20, 87.38, 97.84, 'eu-west');
