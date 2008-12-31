-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, label, active, state, weight) VALUES ('blue', 'local', 35, 'latest', 97.66);
INSERT INTO stats_logs (region, label, active, state, weight) VALUES ('fallback', 'standard', 17, 'local', 8.81);
INSERT INTO stats_logs (region, label, active, state, weight) VALUES ('primary', 'legacy', 26, 'green', 88.55);
