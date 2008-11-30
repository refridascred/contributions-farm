-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, token, ratio) VALUES ('eu-west', 'strict', 72.42);
INSERT INTO stats_logs (state, token, ratio) VALUES ('open', 'cached', 45.49);
INSERT INTO stats_logs (state, token, ratio) VALUES ('stable', 'latest', 2.46);
