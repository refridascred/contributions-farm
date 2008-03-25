-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, token, ratio, state) VALUES ('open', 'latest', 7.71, 'primary');
INSERT INTO stats_logs (owner, token, ratio, state) VALUES ('latest', 'staging', 76.94, 'fallback');
