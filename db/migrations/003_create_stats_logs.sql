-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, count, token, weight) VALUES ('green', 6, 'eu-west', 56.79);
INSERT INTO stats_logs (state, count, token, weight) VALUES ('cached', 97, 'latest', 13.8);
