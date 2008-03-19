-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, label, owner, count, ratio) VALUES ('legacy', 'primary', 'fallback', 95, 10.32);
INSERT INTO stats_logs (state, label, owner, count, ratio) VALUES ('open', 'edge', 'cached', 24, 45.36);
INSERT INTO stats_logs (state, label, owner, count, ratio) VALUES ('fallback', 'cached', 'stable', 25, 7.53);
