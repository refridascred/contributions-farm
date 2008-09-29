-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, score, state, count) VALUES ('latest', 14.5, 'primary', 6);
INSERT INTO stats_logs (token, score, state, count) VALUES ('standard', 1.04, 'legacy', 42);
INSERT INTO stats_logs (token, score, state, count) VALUES ('primary', 45.31, 'legacy', 58);
