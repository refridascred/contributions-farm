-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (token, state, rank, region) VALUES ('primary', 'local', 75, 'cached');
INSERT INTO stats_logs (token, state, rank, region) VALUES ('primary', 'fallback', 23, 'latest');
INSERT INTO stats_logs (token, state, rank, region) VALUES ('open', 'open', 71, 'stable');
