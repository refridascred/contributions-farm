-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, rank, ratio, state, region) VALUES ('latest', 41, 98.18, 'eu-west', 'edge');
INSERT INTO stats_logs (token, rank, ratio, state, region) VALUES ('local', 83, 27.48, 'eu-west', 'primary');
