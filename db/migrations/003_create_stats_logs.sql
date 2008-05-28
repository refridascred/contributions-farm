-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, level, region, score) VALUES ('strict', 77, 'stable', 15.99);
INSERT INTO stats_logs (state, level, region, score) VALUES ('cached', 39, 'blue', 58.79);
INSERT INTO stats_logs (state, level, region, score) VALUES ('local', 35, 'local', 1.32);
