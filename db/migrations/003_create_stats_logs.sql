-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, active, count, state) VALUES ('legacy', 66, 48, 'standard');
INSERT INTO stats_logs (label, active, count, state) VALUES ('eu-west', 85, 88, 'primary');
INSERT INTO stats_logs (label, active, count, state) VALUES ('open', 91, 95, 'primary');
