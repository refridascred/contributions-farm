-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, count, weight, state, score) VALUES (65, 2, 53.01, 'local', 85.98);
INSERT INTO stats_logs (level, count, weight, state, score) VALUES (5, 39, 30.77, 'fallback', 77.54);
INSERT INTO stats_logs (level, count, weight, state, score) VALUES (93, 2, 83.95, 'staging', 85.58);
