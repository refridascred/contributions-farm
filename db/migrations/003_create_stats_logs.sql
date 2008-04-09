-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    created_at TIMESTAMP,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, token, label, state) VALUES (63.12, 'legacy', 'eu-west', 'primary');
INSERT INTO stats_logs (weight, token, label, state) VALUES (12.7, 'cached', 'staging', 'blue');
INSERT INTO stats_logs (weight, token, label, state) VALUES (7.65, 'cached', 'green', 'blue');
