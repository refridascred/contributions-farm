-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, active, label, weight) VALUES ('legacy', 5, 'local', 71.78);
INSERT INTO stats_logs (token, active, label, weight) VALUES ('open', 26, 'blue', 11.09);
