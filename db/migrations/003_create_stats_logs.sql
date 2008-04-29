-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, weight, ratio) VALUES ('fallback', 71.64, 29.01);
INSERT INTO stats_logs (owner, weight, ratio) VALUES ('standard', 31.21, 67.07);
