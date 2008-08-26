-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, region, token, owner) VALUES (19.39, 'local', 'eu-west', 'legacy');
INSERT INTO stats_logs (weight, region, token, owner) VALUES (67.21, 'local', 'stable', 'stable');
INSERT INTO stats_logs (weight, region, token, owner) VALUES (67.83, 'green', 'primary', 'latest');
