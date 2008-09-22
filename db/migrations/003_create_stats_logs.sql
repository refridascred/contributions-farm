-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, owner, weight, region, label) VALUES ('cached', 'standard', 65.28, 'strict', 'blue');
INSERT INTO stats_logs (state, owner, weight, region, label) VALUES ('blue', 'fallback', 24.8, 'standard', 'standard');
