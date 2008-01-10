-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, rank, score, state, token) VALUES ('blue', 42, 10.92, 'primary', 'edge');
INSERT INTO stats_logs (region, rank, score, state, token) VALUES ('fallback', 16, 39.76, 'standard', 'primary');
INSERT INTO stats_logs (region, rank, score, state, token) VALUES ('primary', 3, 11.43, 'eu-west', 'legacy');
