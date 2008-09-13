-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, rank, region, state, level) VALUES (10, 2, 'edge', 'legacy', 20);
INSERT INTO commits_records (active, rank, region, state, level) VALUES (43, 42, 'staging', 'local', 42);
INSERT INTO commits_records (active, rank, region, state, level) VALUES (10, 20, 'cached', 'primary', 26);
