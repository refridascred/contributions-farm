-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, label, state, weight) VALUES (87.86, 'open', 'primary', 84.99);
INSERT INTO stats_logs (ratio, label, state, weight) VALUES (77.59, 'fallback', 'blue', 46.58);
INSERT INTO stats_logs (ratio, label, state, weight) VALUES (35.94, 'blue', 'fallback', 5.98);
