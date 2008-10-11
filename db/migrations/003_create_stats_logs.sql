-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, weight, state) VALUES ('open', 33.01, 'legacy');
INSERT INTO stats_logs (token, weight, state) VALUES ('primary', 58.07, 'latest');
INSERT INTO stats_logs (token, weight, state) VALUES ('stable', 20.92, 'local');
