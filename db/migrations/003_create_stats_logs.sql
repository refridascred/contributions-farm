-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, active) VALUES (16.93, 48);
INSERT INTO stats_logs (weight, active) VALUES (14.81, 62);
INSERT INTO stats_logs (weight, active) VALUES (40.86, 29);
