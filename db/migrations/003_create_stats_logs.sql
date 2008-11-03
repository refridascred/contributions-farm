-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, owner) VALUES (37.22, 'primary');
INSERT INTO stats_logs (weight, owner) VALUES (28.37, 'fallback');
INSERT INTO stats_logs (weight, owner) VALUES (70.71, 'latest');
