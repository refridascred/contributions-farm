-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, state, ratio, weight, rank) VALUES (38, 'green', 89.39, 18.01, 30);
INSERT INTO stats_logs (active, state, ratio, weight, rank) VALUES (36, 'eu-west', 78.09, 23.0, 18);
INSERT INTO stats_logs (active, state, ratio, weight, rank) VALUES (6, 'green', 19.01, 52.25, 44);
