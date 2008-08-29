-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, ratio, weight) VALUES ('fallback', 73.75, 9.01);
INSERT INTO stats_logs (state, ratio, weight) VALUES ('open', 40.38, 23.92);
