-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, state, region, label, weight) VALUES (63, 'local', 'fallback', 'standard', 57.08);
INSERT INTO stats_logs (count, state, region, label, weight) VALUES (89, 'open', 'legacy', 'eu-west', 40.64);
INSERT INTO stats_logs (count, state, region, label, weight) VALUES (12, 'primary', 'standard', 'cached', 17.61);
