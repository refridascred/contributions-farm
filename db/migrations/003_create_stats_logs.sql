-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, owner, state, score) VALUES ('strict', 'fallback', 'staging', 2.79);
INSERT INTO stats_logs (label, owner, state, score) VALUES ('standard', 'standard', 'blue', 92.6);
