-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, weight, score, state, label) VALUES (46, 32.8, 95.62, 'stable', 'edge');
INSERT INTO stats_logs (rank, weight, score, state, label) VALUES (56, 18.72, 72.46, 'fallback', 'stable');
