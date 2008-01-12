-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, level, state, rank) VALUES ('latest', 29, 'eu-west', 35);
INSERT INTO stats_logs (region, level, state, rank) VALUES ('cached', 58, 'local', 25);
