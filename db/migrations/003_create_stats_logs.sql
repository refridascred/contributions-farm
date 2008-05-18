-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, owner) VALUES (52.99, 'latest');
INSERT INTO stats_logs (weight, owner) VALUES (95.03, 'fallback');
INSERT INTO stats_logs (weight, owner) VALUES (93.5, 'edge');
