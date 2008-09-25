-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, level, token, score) VALUES ('stable', 75, 'edge', 51.54);
INSERT INTO stats_logs (state, level, token, score) VALUES ('blue', 49, 'green', 65.26);
INSERT INTO stats_logs (state, level, token, score) VALUES ('stable', 22, 'latest', 30.81);
