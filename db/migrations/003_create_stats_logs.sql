-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, count, weight, score, owner) VALUES ('cached', 70, 65.89, 10.25, 'stable');
INSERT INTO stats_logs (state, count, weight, score, owner) VALUES ('open', 50, 3.82, 42.07, 'blue');
