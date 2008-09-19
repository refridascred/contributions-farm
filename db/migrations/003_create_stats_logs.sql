-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, state, weight, label) VALUES ('blue', 'eu-west', 85.46, 'standard');
INSERT INTO stats_logs (region, state, weight, label) VALUES ('strict', 'strict', 48.2, 'stable');
