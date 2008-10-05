-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, weight, token, state) VALUES ('primary', 90.31, 'open', 'cached');
INSERT INTO stats_logs (region, weight, token, state) VALUES ('eu-west', 42.22, 'standard', 'primary');
INSERT INTO stats_logs (region, weight, token, state) VALUES ('blue', 15.22, 'stable', 'edge');
