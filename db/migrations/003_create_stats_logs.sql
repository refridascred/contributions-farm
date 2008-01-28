-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, token, weight, level, state) VALUES (18, 'edge', 12.46, 67, 'cached');
INSERT INTO stats_logs (count, token, weight, level, state) VALUES (11, 'blue', 41.04, 82, 'green');
