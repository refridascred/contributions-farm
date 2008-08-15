-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, state) VALUES (14.06, 'blue', 'fallback');
INSERT INTO stats_logs (weight, label, state) VALUES (54.07, 'open', 'standard');
INSERT INTO stats_logs (weight, label, state) VALUES (10.06, 'legacy', 'blue');
