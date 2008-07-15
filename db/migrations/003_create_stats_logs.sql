-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, state, ratio, label) VALUES ('latest', 'standard', 4.38, 'edge');
INSERT INTO stats_logs (token, state, ratio, label) VALUES ('open', 'green', 73.2, 'standard');
INSERT INTO stats_logs (token, state, ratio, label) VALUES ('latest', 'strict', 69.4, 'fallback');
