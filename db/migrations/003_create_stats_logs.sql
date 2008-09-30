-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, level, score, weight, state) VALUES (39, 4, 79.26, 28.31, 'green');
INSERT INTO stats_logs (count, level, score, weight, state) VALUES (0, 72, 25.01, 72.84, 'legacy');
