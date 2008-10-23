-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, token, count, ratio) VALUES ('cached', 'legacy', 18, 75.61);
INSERT INTO stats_logs (state, token, count, ratio) VALUES ('green', 'staging', 12, 92.72);
INSERT INTO stats_logs (state, token, count, ratio) VALUES ('standard', 'strict', 40, 23.89);
