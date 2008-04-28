-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, score, rank, label) VALUES ('edge', 3.39, 45, 'fallback');
INSERT INTO stats_logs (owner, score, rank, label) VALUES ('green', 2.41, 40, 'edge');
INSERT INTO stats_logs (owner, score, rank, label) VALUES ('fallback', 50.95, 6, 'standard');
