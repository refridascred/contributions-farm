-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (weight, rank, label, state) VALUES (85.66, 62, 'standard', 'strict');
INSERT INTO stats_logs (weight, rank, label, state) VALUES (18.56, 28, 'fallback', 'primary');
INSERT INTO stats_logs (weight, rank, label, state) VALUES (65.79, 10, 'strict', 'cached');
