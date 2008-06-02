-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, weight, active) VALUES ('eu-west', 7.21, 18);
INSERT INTO stats_logs (state, weight, active) VALUES ('cached', 52.63, 78);
INSERT INTO stats_logs (state, weight, active) VALUES ('legacy', 80.77, 25);
