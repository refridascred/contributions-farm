-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, state, owner, weight) VALUES ('blue', 'strict', 'fallback', 45.17);
INSERT INTO stats_logs (label, state, owner, weight) VALUES ('local', 'standard', 'legacy', 67.01);
INSERT INTO stats_logs (label, state, owner, weight) VALUES ('strict', 'green', 'legacy', 81.63);
