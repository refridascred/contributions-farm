-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, weight, label, region) VALUES ('strict', 26.71, 'strict', 'legacy');
INSERT INTO stats_logs (state, weight, label, region) VALUES ('stable', 34.53, 'eu-west', 'legacy');
