-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, active, score) VALUES ('staging', 1, 38.65);
INSERT INTO stats_logs (owner, active, score) VALUES ('edge', 3, 46.27);
INSERT INTO stats_logs (owner, active, score) VALUES ('fallback', 73, 4.68);
