-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, owner, weight, label, state) VALUES (49.92, 'standard', 29.24, 'primary', 'fallback');
INSERT INTO stats_logs (score, owner, weight, label, state) VALUES (22.45, 'local', 50.64, 'latest', 'edge');
