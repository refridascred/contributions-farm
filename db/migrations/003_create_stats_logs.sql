-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, score, level, rank) VALUES ('fallback', 9.24, 85, 95);
INSERT INTO stats_logs (state, score, level, rank) VALUES ('legacy', 79.13, 80, 70);
INSERT INTO stats_logs (state, score, level, rank) VALUES ('staging', 31.81, 42, 83);
