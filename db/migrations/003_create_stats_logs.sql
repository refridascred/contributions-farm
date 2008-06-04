-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, region, state, weight) VALUES (72.46, 'standard', 'latest', 87.38);
INSERT INTO stats_logs (score, region, state, weight) VALUES (85.5, 'local', 'legacy', 15.51);
INSERT INTO stats_logs (score, region, state, weight) VALUES (22.45, 'latest', 'cached', 81.31);
