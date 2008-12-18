-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (token, state, level) VALUES ('eu-west', 'strict', 5);
INSERT INTO stats_logs (token, state, level) VALUES ('eu-west', 'green', 21);
INSERT INTO stats_logs (token, state, level) VALUES ('edge', 'local', 31);
