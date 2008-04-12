-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, score, rank, label) VALUES ('latest', 27.03, 69, 'green');
INSERT INTO stats_logs (owner, score, rank, label) VALUES ('strict', 94.16, 8, 'legacy');
INSERT INTO stats_logs (owner, score, rank, label) VALUES ('edge', 86.34, 95, 'local');
