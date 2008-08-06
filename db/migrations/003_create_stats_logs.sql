-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, state, token, weight, label) VALUES ('latest', 'open', 'staging', 20.52, 'standard');
INSERT INTO stats_logs (region, state, token, weight, label) VALUES ('open', 'strict', 'latest', 27.35, 'green');
