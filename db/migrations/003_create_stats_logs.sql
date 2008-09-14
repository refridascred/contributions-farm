-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, token, active, score, state) VALUES ('strict', 'open', 11, 87.33, 'staging');
INSERT INTO stats_logs (label, token, active, score, state) VALUES ('strict', 'primary', 76, 88.32, 'local');
