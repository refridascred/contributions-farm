-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, rank, weight, active) VALUES ('fallback', 70, 1.55, 63);
INSERT INTO stats_logs (token, rank, weight, active) VALUES ('strict', 59, 14.29, 76);
INSERT INTO stats_logs (token, rank, weight, active) VALUES ('blue', 27, 58.29, 42);
