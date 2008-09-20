-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, state, label, weight) VALUES ('fallback', 'cached', 'cached', 85.29);
INSERT INTO stats_logs (region, state, label, weight) VALUES ('standard', 'legacy', 'cached', 60.66);
