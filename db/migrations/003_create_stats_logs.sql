-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, owner, score, count, ratio) VALUES ('legacy', 'fallback', 66.17, 45, 82.29);
INSERT INTO stats_logs (state, owner, score, count, ratio) VALUES ('open', 'strict', 31.08, 9, 16.24);
