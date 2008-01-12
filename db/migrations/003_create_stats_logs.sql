-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, token, weight, region) VALUES ('strict', 'primary', 10.24, 'open');
INSERT INTO stats_logs (state, token, weight, region) VALUES ('open', 'latest', 46.35, 'stable');
INSERT INTO stats_logs (state, token, weight, region) VALUES ('staging', 'green', 32.53, 'open');
