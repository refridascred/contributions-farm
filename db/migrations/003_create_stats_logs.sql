-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, weight, ratio, score) VALUES ('edge', 77.24, 64.35, 74.62);
INSERT INTO stats_logs (owner, weight, ratio, score) VALUES ('staging', 43.74, 48.98, 73.61);
INSERT INTO stats_logs (owner, weight, ratio, score) VALUES ('fallback', 51.23, 78.21, 20.52);
