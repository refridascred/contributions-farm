-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, token, state) VALUES (91.54, 'cached', 'open');
INSERT INTO stats_logs (weight, token, state) VALUES (36.93, 'stable', 'local');
