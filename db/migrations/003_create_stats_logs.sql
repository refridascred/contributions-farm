-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, region, weight, label) VALUES ('standard', 'fallback', 76.26, 'staging');
INSERT INTO stats_logs (state, region, weight, label) VALUES ('cached', 'strict', 37.98, 'eu-west');
