-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, token, state, count, ratio) VALUES ('latest', 'cached', 'latest', 27, 68.96);
INSERT INTO stats_logs (label, token, state, count, ratio) VALUES ('edge', 'blue', 'blue', 16, 62.4);
INSERT INTO stats_logs (label, token, state, count, ratio) VALUES ('legacy', 'strict', 'local', 85, 38.15);
