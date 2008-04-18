-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, count, owner, level, state) VALUES ('cached', 11, 'stable', 43, 'standard');
INSERT INTO stats_logs (token, count, owner, level, state) VALUES ('blue', 31, 'blue', 34, 'strict');
INSERT INTO stats_logs (token, count, owner, level, state) VALUES ('stable', 45, 'eu-west', 42, 'stable');
