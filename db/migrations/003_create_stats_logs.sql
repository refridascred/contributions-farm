-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, ratio, state, level) VALUES ('standard', 87.32, 'blue', 85);
INSERT INTO stats_logs (token, ratio, state, level) VALUES ('blue', 17.48, 'blue', 5);
INSERT INTO stats_logs (token, ratio, state, level) VALUES ('staging', 57.83, 'cached', 39);
