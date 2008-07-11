-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, state) VALUES (5, 'eu-west');
INSERT INTO stats_logs (count, state) VALUES (91, 'stable');
INSERT INTO stats_logs (count, state) VALUES (27, 'fallback');
