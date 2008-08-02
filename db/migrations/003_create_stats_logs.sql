-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, region, token, state) VALUES (76.72, 'legacy', 'edge', 'cached');
INSERT INTO stats_logs (weight, region, token, state) VALUES (56.23, 'latest', 'open', 'local');
