-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, token, count) VALUES ('green', 54.75, 'legacy', 40);
INSERT INTO stats_logs (state, weight, token, count) VALUES ('legacy', 81.98, 'blue', 6);
INSERT INTO stats_logs (state, weight, token, count) VALUES ('cached', 87.7, 'strict', 66);
