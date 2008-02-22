-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, state, owner, weight) VALUES (66, 'primary', 'blue', 'primary', 39.68);
INSERT INTO stats_logs (level, label, state, owner, weight) VALUES (32, 'fallback', 'eu-west', 'standard', 92.64);
INSERT INTO stats_logs (level, label, state, owner, weight) VALUES (35, 'cached', 'eu-west', 'green', 59.19);
