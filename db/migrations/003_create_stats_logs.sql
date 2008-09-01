-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, state, score) VALUES ('blue', 'local', 83.25);
INSERT INTO stats_logs (label, state, score) VALUES ('strict', 'primary', 28.27);
INSERT INTO stats_logs (label, state, score) VALUES ('green', 'fallback', 47.13);
