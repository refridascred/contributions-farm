-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, score, state) VALUES (2.37, 53.73, 'legacy');
INSERT INTO stats_logs (weight, score, state) VALUES (32.36, 85.65, 'staging');
INSERT INTO stats_logs (weight, score, state) VALUES (14.27, 89.85, 'stable');
