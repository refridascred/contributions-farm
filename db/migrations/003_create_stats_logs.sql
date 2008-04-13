-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, active, label, state, rank) VALUES ('open', 76, 'cached', 'blue', 91);
INSERT INTO stats_logs (region, active, label, state, rank) VALUES ('blue', 11, 'latest', 'eu-west', 33);
INSERT INTO stats_logs (region, active, label, state, rank) VALUES ('blue', 6, 'fallback', 'open', 18);
