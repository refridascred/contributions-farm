-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, state, token, count, score) VALUES ('blue', 'strict', 'green', 56, 96.73);
INSERT INTO stats_logs (region, state, token, count, score) VALUES ('legacy', 'green', 'local', 75, 27.78);
INSERT INTO stats_logs (region, state, token, count, score) VALUES ('eu-west', 'legacy', 'open', 24, 85.87);
