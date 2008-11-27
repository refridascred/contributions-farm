-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, score, owner) VALUES ('green', 54, 24.05, 'blue');
INSERT INTO stats_logs (label, rank, score, owner) VALUES ('strict', 66, 66.89, 'edge');
INSERT INTO stats_logs (label, rank, score, owner) VALUES ('green', 52, 5.06, 'strict');
