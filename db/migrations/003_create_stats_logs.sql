-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, active, state, ratio, label) VALUES (26, 62, 'green', 68.26, 'edge');
INSERT INTO stats_logs (rank, active, state, ratio, label) VALUES (38, 27, 'staging', 87.29, 'stable');
