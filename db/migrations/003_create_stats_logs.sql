-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, weight, token, state, label) VALUES ('stable', 26.31, 'stable', 'latest', 'stable');
INSERT INTO stats_logs (owner, weight, token, state, label) VALUES ('open', 56.02, 'staging', 'staging', 'legacy');
INSERT INTO stats_logs (owner, weight, token, state, label) VALUES ('primary', 66.81, 'blue', 'eu-west', 'legacy');
