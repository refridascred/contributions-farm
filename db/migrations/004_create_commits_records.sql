-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, state, region, score, rank) VALUES (34, 'legacy', 'local', 90.66, 61);
INSERT INTO commits_records (active, state, region, score, rank) VALUES (53, 'cached', 'primary', 58.48, 44);
INSERT INTO commits_records (active, state, region, score, rank) VALUES (69, 'blue', 'eu-west', 60.87, 92);
