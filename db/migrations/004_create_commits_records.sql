-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, owner, region, active) VALUES ('latest', 'latest', 'green', 70);
INSERT INTO commits_records (state, owner, region, active) VALUES ('stable', 'standard', 'primary', 98);
INSERT INTO commits_records (state, owner, region, active) VALUES ('blue', 'stable', 'legacy', 31);
