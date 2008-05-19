-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, state, score, owner) VALUES ('local', 'open', 82.87, 'strict');
INSERT INTO stats_logs (label, state, score, owner) VALUES ('standard', 'standard', 69.28, 'stable');
INSERT INTO stats_logs (label, state, score, owner) VALUES ('latest', 'local', 23.2, 'blue');
