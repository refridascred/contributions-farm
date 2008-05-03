-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, state, level, label) VALUES (90, 'legacy', 13, 'local');
INSERT INTO stats_logs (rank, state, level, label) VALUES (87, 'legacy', 94, 'standard');
