-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, weight, count, token, state) VALUES (13, 12.92, 29, 'blue', 'latest');
INSERT INTO stats_logs (level, weight, count, token, state) VALUES (4, 83.6, 43, 'cached', 'legacy');
INSERT INTO stats_logs (level, weight, count, token, state) VALUES (82, 91.16, 54, 'staging', 'strict');
