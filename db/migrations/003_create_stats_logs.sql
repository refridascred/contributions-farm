-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, label, score, count, state) VALUES (67.49, 'green', 92.4, 63, 'fallback');
INSERT INTO stats_logs (weight, label, score, count, state) VALUES (78.6, 'legacy', 42.29, 58, 'legacy');
INSERT INTO stats_logs (weight, label, score, count, state) VALUES (18.41, 'strict', 11.85, 82, 'standard');
