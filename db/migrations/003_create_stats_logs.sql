-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (count, label, state, weight, ratio) VALUES (9, 'strict', 'fallback', 71.8, 31.52);
INSERT INTO stats_logs (count, label, state, weight, ratio) VALUES (64, 'blue', 'open', 7.42, 31.07);
INSERT INTO stats_logs (count, label, state, weight, ratio) VALUES (22, 'eu-west', 'edge', 6.33, 59.1);
