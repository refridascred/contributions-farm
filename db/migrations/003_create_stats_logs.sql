-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, token, owner) VALUES (11.13, 'blue', 'standard');
INSERT INTO stats_logs (weight, token, owner) VALUES (48.58, 'legacy', 'cached');
