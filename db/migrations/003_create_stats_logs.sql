-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, owner, state, ratio) VALUES (44.75, 'stable', 'stable', 23.4);
INSERT INTO stats_logs (weight, owner, state, ratio) VALUES (59.97, 'cached', 'cached', 89.46);
INSERT INTO stats_logs (weight, owner, state, ratio) VALUES (60.87, 'fallback', 'green', 4.48);
