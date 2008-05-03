-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, token, count) VALUES ('blue', 'eu-west', 46);
INSERT INTO stats_logs (state, token, count) VALUES ('open', 'primary', 60);
INSERT INTO stats_logs (state, token, count) VALUES ('cached', 'green', 62);
