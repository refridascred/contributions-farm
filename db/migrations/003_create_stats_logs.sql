-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, state, score, level, weight) VALUES ('edge', 'blue', 81.51, 77, 71.45);
INSERT INTO stats_logs (token, state, score, level, weight) VALUES ('legacy', 'blue', 65.87, 83, 55.0);
INSERT INTO stats_logs (token, state, score, level, weight) VALUES ('strict', 'green', 65.87, 87, 68.79);
