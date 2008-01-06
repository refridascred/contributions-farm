-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, token, state) VALUES (63, 'cached', 'blue');
INSERT INTO stats_logs (level, token, state) VALUES (76, 'eu-west', 'strict');
INSERT INTO stats_logs (level, token, state) VALUES (86, 'cached', 'stable');
