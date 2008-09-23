-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, weight, state) VALUES ('local', 76.13, 'cached');
INSERT INTO stats_logs (label, weight, state) VALUES ('fallback', 75.32, 'fallback');
INSERT INTO stats_logs (label, weight, state) VALUES ('open', 74.97, 'legacy');
