-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, region, active, score, label) VALUES ('strict', 'edge', 12, 45.17, 'local');
INSERT INTO stats_logs (state, region, active, score, label) VALUES ('blue', 'open', 11, 26.67, 'local');
