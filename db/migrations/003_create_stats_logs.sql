-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, token, level, state, label) VALUES (67.75, 'blue', 92, 'blue', 'staging');
INSERT INTO stats_logs (weight, token, level, state, label) VALUES (93.76, 'stable', 37, 'open', 'legacy');
INSERT INTO stats_logs (weight, token, level, state, label) VALUES (64.11, 'green', 4, 'strict', 'local');
