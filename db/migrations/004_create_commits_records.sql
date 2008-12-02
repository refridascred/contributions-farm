-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, weight, owner, region) VALUES ('legacy', 13.62, 'green', 'latest');
INSERT INTO commits_records (state, weight, owner, region) VALUES ('green', 11.44, 'legacy', 'local');
INSERT INTO commits_records (state, weight, owner, region) VALUES ('standard', 3.97, 'open', 'blue');
