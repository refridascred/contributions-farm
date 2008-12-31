-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (token, state, count) VALUES ('stable', 'eu-west', 60);
INSERT INTO stats_logs (token, state, count) VALUES ('local', 'fallback', 21);
INSERT INTO stats_logs (token, state, count) VALUES ('staging', 'open', 75);
