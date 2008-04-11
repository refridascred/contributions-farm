-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, ratio, state, count) VALUES ('open', 26, 78.47, 'local', 71);
INSERT INTO stats_logs (label, rank, ratio, state, count) VALUES ('primary', 70, 66.58, 'stable', 84);
