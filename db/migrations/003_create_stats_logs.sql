-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, count, owner) VALUES ('blue', 0, 'latest');
INSERT INTO stats_logs (state, count, owner) VALUES ('standard', 64, 'edge');
INSERT INTO stats_logs (state, count, owner) VALUES ('strict', 38, 'fallback');
