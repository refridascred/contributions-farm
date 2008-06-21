-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, state, rank, active, count) VALUES ('legacy', 'primary', 56, 15, 71);
INSERT INTO stats_logs (label, state, rank, active, count) VALUES ('cached', 'fallback', 17, 11, 3);
INSERT INTO stats_logs (label, state, rank, active, count) VALUES ('standard', 'cached', 68, 44, 0);
