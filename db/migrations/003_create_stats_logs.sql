-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, level, state, rank) VALUES (77.9, 'cached', 72, 'stable', 11);
INSERT INTO stats_logs (score, label, level, state, rank) VALUES (42.61, 'local', 96, 'legacy', 97);
