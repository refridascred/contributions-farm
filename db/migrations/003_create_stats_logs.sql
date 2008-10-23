-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, owner) VALUES (75.61, 'eu-west');
INSERT INTO stats_logs (weight, owner) VALUES (35.87, 'staging');
INSERT INTO stats_logs (weight, owner) VALUES (69.96, 'staging');
