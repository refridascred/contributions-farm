-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, owner, region, state, weight) VALUES (39, 'primary', 'eu-west', 'strict', 63.23);
INSERT INTO stats_logs (rank, owner, region, state, weight) VALUES (87, 'green', 'staging', 'eu-west', 21.92);
