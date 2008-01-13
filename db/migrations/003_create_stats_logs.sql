-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, weight, state, label, level) VALUES (12, 12.33, 'primary', 'latest', 13);
INSERT INTO stats_logs (rank, weight, state, label, level) VALUES (25, 75.8, 'legacy', 'standard', 60);
