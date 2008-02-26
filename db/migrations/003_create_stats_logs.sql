-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    rank INTEGER,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, token, rank, level, state) VALUES (71.54, 'green', 21, 77, 'open');
INSERT INTO stats_logs (score, token, rank, level, state) VALUES (24.8, 'staging', 12, 80, 'legacy');
INSERT INTO stats_logs (score, token, rank, level, state) VALUES (21.79, 'stable', 33, 76, 'cached');
