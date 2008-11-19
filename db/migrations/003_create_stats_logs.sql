-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank, active, state, weight) VALUES ('primary', 39, 19, 'staging', 31.55);
INSERT INTO stats_logs (region, rank, active, state, weight) VALUES ('eu-west', 38, 21, 'edge', 48.43);
INSERT INTO stats_logs (region, rank, active, state, weight) VALUES ('strict', 17, 64, 'eu-west', 93.69);
