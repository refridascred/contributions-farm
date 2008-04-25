-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, state, region) VALUES (85.02, 'eu-west', 'standard');
INSERT INTO stats_logs (weight, state, region) VALUES (85.21, 'local', 'open');
INSERT INTO stats_logs (weight, state, region) VALUES (92.38, 'standard', 'blue');
