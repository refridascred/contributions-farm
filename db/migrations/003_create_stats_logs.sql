-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, ratio, state) VALUES (77.41, 94.06, 'primary');
INSERT INTO stats_logs (score, ratio, state) VALUES (69.55, 17.22, 'legacy');
INSERT INTO stats_logs (score, ratio, state) VALUES (97.91, 44.61, 'standard');
