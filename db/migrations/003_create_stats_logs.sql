-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, token, ratio) VALUES ('eu-west', 'edge', 40.47);
INSERT INTO stats_logs (state, token, ratio) VALUES ('latest', 'eu-west', 29.59);
