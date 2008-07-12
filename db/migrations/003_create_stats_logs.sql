-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, token) VALUES (85.2, 'standard');
INSERT INTO stats_logs (weight, token) VALUES (95.36, 'strict');
INSERT INTO stats_logs (weight, token) VALUES (55.58, 'strict');
