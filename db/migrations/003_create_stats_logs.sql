-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, rank, weight, state, region) VALUES (13.78, 78, 66.67, 'green', 'standard');
INSERT INTO stats_logs (score, rank, weight, state, region) VALUES (28.97, 69, 25.7, 'standard', 'latest');
INSERT INTO stats_logs (score, rank, weight, state, region) VALUES (45.75, 42, 56.52, 'latest', 'legacy');
