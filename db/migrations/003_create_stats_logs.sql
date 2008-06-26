-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, owner, state) VALUES ('stable', 46.6, 'staging', 'green');
INSERT INTO stats_logs (label, score, owner, state) VALUES ('latest', 57.6, 'eu-west', 'green');
INSERT INTO stats_logs (label, score, owner, state) VALUES ('stable', 64.99, 'fallback', 'fallback');
