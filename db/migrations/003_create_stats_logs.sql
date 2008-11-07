-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, token, state) VALUES ('eu-west', 'standard', 'local');
INSERT INTO stats_logs (region, token, state) VALUES ('eu-west', 'cached', 'cached');
INSERT INTO stats_logs (region, token, state) VALUES ('stable', 'standard', 'open');
