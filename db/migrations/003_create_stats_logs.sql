-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, label, count, score, region) VALUES ('staging', 'primary', 43, 74.93, 'stable');
INSERT INTO stats_logs (state, label, count, score, region) VALUES ('cached', 'staging', 93, 7.35, 'green');
INSERT INTO stats_logs (state, label, count, score, region) VALUES ('staging', 'staging', 40, 34.41, 'local');
