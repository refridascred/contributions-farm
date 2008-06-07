-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, active, token, ratio) VALUES ('local', 69, 'latest', 86.91);
INSERT INTO stats_logs (state, active, token, ratio) VALUES ('green', 42, 'green', 16.05);
INSERT INTO stats_logs (state, active, token, ratio) VALUES ('cached', 82, 'latest', 47.3);
