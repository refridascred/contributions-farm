-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, state, weight) VALUES ('primary', 27.59, 'staging', 2.15);
INSERT INTO stats_logs (label, score, state, weight) VALUES ('green', 86.71, 'standard', 92.57);
