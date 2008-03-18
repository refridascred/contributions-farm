-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, token, state, label) VALUES (78.99, 'eu-west', 'legacy', 'blue');
INSERT INTO stats_logs (weight, token, state, label) VALUES (81.19, 'eu-west', 'blue', 'fallback');
INSERT INTO stats_logs (weight, token, state, label) VALUES (98.2, 'primary', 'blue', 'staging');
