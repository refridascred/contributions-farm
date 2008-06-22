-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, ratio, owner) VALUES (41, 54.74, 'green');
INSERT INTO stats_logs (count, ratio, owner) VALUES (40, 5.63, 'strict');
INSERT INTO stats_logs (count, ratio, owner) VALUES (40, 60.77, 'staging');
