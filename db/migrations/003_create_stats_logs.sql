-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, state, weight, region) VALUES (64, 'green', 2.96, 'open');
INSERT INTO stats_logs (count, state, weight, region) VALUES (44, 'primary', 88.08, 'cached');
