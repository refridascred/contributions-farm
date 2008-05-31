-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, label, score) VALUES (39.97, 'legacy', 'strict', 11.27);
INSERT INTO stats_logs (ratio, state, label, score) VALUES (96.66, 'open', 'strict', 94.8);
INSERT INTO stats_logs (ratio, state, label, score) VALUES (77.13, 'staging', 'latest', 1.6);
