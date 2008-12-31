-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, owner, ratio, token, state) VALUES ('legacy', 'local', 88.59, 'green', 'latest');
INSERT INTO commits_records (region, owner, ratio, token, state) VALUES ('staging', 'cached', 80.59, 'latest', 'cached');
INSERT INTO commits_records (region, owner, ratio, token, state) VALUES ('stable', 'standard', 39.46, 'local', 'staging');
