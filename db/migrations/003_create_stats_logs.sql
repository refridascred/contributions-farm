-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, weight, state, active) VALUES ('legacy', 78.5, 'blue', 87);
INSERT INTO stats_logs (owner, weight, state, active) VALUES ('local', 16.18, 'eu-west', 84);
