-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, weight, state) VALUES (22, 69.57, 'fallback');
INSERT INTO stats_logs (count, weight, state) VALUES (97, 52.18, 'strict');
INSERT INTO stats_logs (count, weight, state) VALUES (55, 96.92, 'cached');
