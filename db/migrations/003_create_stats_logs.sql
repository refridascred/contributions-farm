-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, state, count, score) VALUES ('strict', 'standard', 79, 86.24);
INSERT INTO stats_logs (region, state, count, score) VALUES ('blue', 'local', 92, 94.8);
INSERT INTO stats_logs (region, state, count, score) VALUES ('standard', 'local', 61, 14.97);
