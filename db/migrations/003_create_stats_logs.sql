-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, ratio, owner) VALUES (58.45, 94.32, 'legacy');
INSERT INTO stats_logs (weight, ratio, owner) VALUES (79.75, 52.92, 'eu-west');
