-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label) VALUES (42.1, 'eu-west');
INSERT INTO stats_logs (score, label) VALUES (36.22, 'fallback');
INSERT INTO stats_logs (score, label) VALUES (41.96, 'legacy');
