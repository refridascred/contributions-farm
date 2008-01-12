-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, owner, region) VALUES (97.9, 'eu-west', 'legacy');
INSERT INTO stats_logs (weight, owner, region) VALUES (31.76, 'open', 'edge');
INSERT INTO stats_logs (weight, owner, region) VALUES (0.18, 'local', 'strict');
