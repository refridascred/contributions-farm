-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, region, state) VALUES (83.82, 'fallback', 'legacy');
INSERT INTO stats_logs (weight, region, state) VALUES (76.05, 'latest', 'blue');
INSERT INTO stats_logs (weight, region, state) VALUES (85.49, 'stable', 'stable');
