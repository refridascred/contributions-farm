-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (active, region, state) VALUES (57, 'legacy', 'open');
INSERT INTO commits_records (active, region, state) VALUES (68, 'latest', 'edge');
INSERT INTO commits_records (active, region, state) VALUES (90, 'standard', 'green');
