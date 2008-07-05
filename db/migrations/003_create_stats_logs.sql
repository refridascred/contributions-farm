-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, region, state, ratio, owner) VALUES (93.47, 'local', 'stable', 39.52, 'stable');
INSERT INTO stats_logs (weight, region, state, ratio, owner) VALUES (76.99, 'eu-west', 'local', 36.42, 'fallback');
