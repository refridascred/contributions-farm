-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, active, label, token, ratio) VALUES ('eu-west', 63, 'local', 'blue', 55.91);
INSERT INTO stats_logs (state, active, label, token, ratio) VALUES ('cached', 33, 'fallback', 'stable', 27.48);
INSERT INTO stats_logs (state, active, label, token, ratio) VALUES ('standard', 57, 'standard', 'eu-west', 63.13);
