-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, weight, state, score) VALUES ('fallback', 16.75, 'local', 66.82);
INSERT INTO stats_logs (owner, weight, state, score) VALUES ('cached', 75.19, 'green', 68.84);
