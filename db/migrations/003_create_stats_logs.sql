-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, region, weight, ratio, state) VALUES ('blue', 'cached', 9.35, 71.29, 'primary');
INSERT INTO stats_logs (token, region, weight, ratio, state) VALUES ('eu-west', 'cached', 58.52, 11.54, 'stable');
INSERT INTO stats_logs (token, region, weight, ratio, state) VALUES ('latest', 'edge', 54.4, 16.35, 'eu-west');
