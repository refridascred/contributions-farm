-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, weight, owner) VALUES (89.71, 29.45, 'green');
INSERT INTO stats_logs (ratio, weight, owner) VALUES (43.83, 11.61, 'strict');
