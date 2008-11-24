-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, state, level, weight, region) VALUES ('eu-west', 'strict', 43, 98.34, 'legacy');
INSERT INTO stats_logs (token, state, level, weight, region) VALUES ('blue', 'legacy', 66, 98.64, 'latest');
INSERT INTO stats_logs (token, state, level, weight, region) VALUES ('eu-west', 'fallback', 86, 8.82, 'open');
