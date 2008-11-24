-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, count, rank, state) VALUES (97, 19, 60, 'eu-west');
INSERT INTO stats_logs (active, count, rank, state) VALUES (87, 82, 10, 'local');
INSERT INTO stats_logs (active, count, rank, state) VALUES (81, 50, 34, 'stable');
