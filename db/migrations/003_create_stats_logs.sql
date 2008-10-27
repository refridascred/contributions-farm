-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, ratio, active, score) VALUES ('latest', 8.01, 67, 11.71);
INSERT INTO stats_logs (owner, ratio, active, score) VALUES ('standard', 58.81, 11, 43.5);
