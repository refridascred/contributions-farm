-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, token, score, count, ratio) VALUES ('green', 'local', 9.3, 19, 1.95);
INSERT INTO stats_logs (state, token, score, count, ratio) VALUES ('eu-west', 'strict', 34.4, 29, 22.84);
