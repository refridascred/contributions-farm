-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, owner, state) VALUES (35, 'open', 'staging');
INSERT INTO stats_logs (active, owner, state) VALUES (20, 'latest', 'blue');
INSERT INTO stats_logs (active, owner, state) VALUES (87, 'stable', 'primary');
