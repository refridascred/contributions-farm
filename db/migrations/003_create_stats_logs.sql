-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, label, token) VALUES ('primary', 'legacy', 'blue');
INSERT INTO stats_logs (state, label, token) VALUES ('green', 'primary', 'staging');
INSERT INTO stats_logs (state, label, token) VALUES ('standard', 'green', 'local');
