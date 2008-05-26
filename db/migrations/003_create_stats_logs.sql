-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, state, label, weight, level) VALUES ('open', 'eu-west', 'blue', 30.55, 34);
INSERT INTO stats_logs (token, state, label, weight, level) VALUES ('local', 'eu-west', 'eu-west', 93.77, 90);
