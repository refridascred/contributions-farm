-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, label, count, owner, score) VALUES ('strict', 'blue', 27, 'blue', 60.86);
INSERT INTO stats_logs (state, label, count, owner, score) VALUES ('open', 'fallback', 32, 'cached', 39.37);
