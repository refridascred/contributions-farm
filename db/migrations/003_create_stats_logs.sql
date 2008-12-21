-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, owner, token, level) VALUES ('blue', 'open', 'blue', 41);
INSERT INTO stats_logs (state, owner, token, level) VALUES ('local', 'eu-west', 'fallback', 98);
INSERT INTO stats_logs (state, owner, token, level) VALUES ('edge', 'cached', 'cached', 63);
