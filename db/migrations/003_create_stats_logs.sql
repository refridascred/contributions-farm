-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, weight, count, owner) VALUES ('blue', 80.21, 60, 'strict');
INSERT INTO stats_logs (state, weight, count, owner) VALUES ('blue', 33.95, 76, 'edge');
INSERT INTO stats_logs (state, weight, count, owner) VALUES ('eu-west', 95.97, 22, 'staging');
