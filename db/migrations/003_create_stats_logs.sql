-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, active) VALUES (45.85, 41);
INSERT INTO stats_logs (weight, active) VALUES (13.16, 3);
INSERT INTO stats_logs (weight, active) VALUES (91.29, 73);
