-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, active, count) VALUES ('strict', 75, 21);
INSERT INTO stats_logs (state, active, count) VALUES ('strict', 66, 80);
INSERT INTO stats_logs (state, active, count) VALUES ('cached', 81, 68);
