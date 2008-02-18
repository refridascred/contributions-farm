-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, weight, label, region, token) VALUES ('green', 16.65, 'green', 'primary', 'fallback');
INSERT INTO stats_logs (state, weight, label, region, token) VALUES ('edge', 89.77, 'cached', 'fallback', 'primary');
