-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, state, active, ratio) VALUES ('strict', 'cached', 6, 25.63);
INSERT INTO stats_logs (token, state, active, ratio) VALUES ('staging', 'legacy', 92, 83.51);
