-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, label, score) VALUES ('latest', 48, 'fallback', 98.42);
INSERT INTO stats_logs (owner, rank, label, score) VALUES ('eu-west', 12, 'primary', 12.41);
INSERT INTO stats_logs (owner, rank, label, score) VALUES ('strict', 88, 'staging', 51.64);
