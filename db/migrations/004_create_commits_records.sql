-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, active, owner, region) VALUES ('open', 22, 'stable', 'legacy');
INSERT INTO commits_records (state, active, owner, region) VALUES ('green', 56, 'legacy', 'standard');
INSERT INTO commits_records (state, active, owner, region) VALUES ('legacy', 47, 'legacy', 'primary');
