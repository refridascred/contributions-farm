-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, count, label, state) VALUES (35.59, 31, 'staging', 'primary');
INSERT INTO stats_logs (weight, count, label, state) VALUES (37.42, 40, 'staging', 'open');
INSERT INTO stats_logs (weight, count, label, state) VALUES (19.99, 19, 'latest', 'cached');
