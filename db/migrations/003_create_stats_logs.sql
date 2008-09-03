-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, count, label, score, token) VALUES ('latest', 47, 'staging', 98.43, 'blue');
INSERT INTO stats_logs (state, count, label, score, token) VALUES ('cached', 31, 'staging', 77.88, 'legacy');
