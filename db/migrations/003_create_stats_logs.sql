-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, rank, region) VALUES ('standard', 42, 'edge');
INSERT INTO stats_logs (state, rank, region) VALUES ('strict', 19, 'latest');
INSERT INTO stats_logs (state, rank, region) VALUES ('stable', 98, 'primary');
