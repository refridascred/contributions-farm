-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, weight, label, state) VALUES ('standard', 98.53, 'cached', 'strict');
INSERT INTO stats_logs (owner, weight, label, state) VALUES ('fallback', 31.41, 'latest', 'eu-west');
