-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, score) VALUES (38.64, 'cached', 60.79);
INSERT INTO stats_logs (ratio, state, score) VALUES (18.87, 'edge', 81.86);
INSERT INTO stats_logs (ratio, state, score) VALUES (67.87, 'open', 83.4);
