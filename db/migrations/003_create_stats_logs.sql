-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, weight) VALUES ('edge', 20.15);
INSERT INTO stats_logs (owner, weight) VALUES ('green', 35.43);
INSERT INTO stats_logs (owner, weight) VALUES ('stable', 75.65);
