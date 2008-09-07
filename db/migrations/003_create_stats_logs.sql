-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, score, count, weight, state) VALUES ('standard', 20.21, 50, 56.06, 'legacy');
INSERT INTO stats_logs (owner, score, count, weight, state) VALUES ('blue', 50.2, 87, 32.36, 'staging');
INSERT INTO stats_logs (owner, score, count, weight, state) VALUES ('stable', 41.92, 2, 14.85, 'latest');
