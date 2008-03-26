-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, weight, region, active, token) VALUES (74, 44.31, 'primary', 11, 'local');
INSERT INTO stats_logs (rank, weight, region, active, token) VALUES (37, 85.75, 'eu-west', 32, 'standard');
INSERT INTO stats_logs (rank, weight, region, active, token) VALUES (44, 7.14, 'staging', 2, 'blue');
