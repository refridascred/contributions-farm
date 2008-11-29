-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, label, token) VALUES ('primary', 85.24, 'staging', 'cached');
INSERT INTO stats_logs (state, weight, label, token) VALUES ('cached', 10.07, 'green', 'open');
