-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, region, count, state, ratio) VALUES (45.65, 'fallback', 48, 'strict', 73.56);
INSERT INTO stats_logs (score, region, count, state, ratio) VALUES (9.14, 'stable', 4, 'blue', 83.79);
