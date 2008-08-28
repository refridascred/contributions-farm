-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, label, state, token) VALUES (39.81, 'strict', 'open', 'fallback');
INSERT INTO stats_logs (weight, label, state, token) VALUES (87.48, 'green', 'staging', 'staging');
