-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, rank, region, state) VALUES ('fallback', 18, 'cached', 'blue');
INSERT INTO commits_records (owner, rank, region, state) VALUES ('open', 4, 'local', 'strict');
INSERT INTO commits_records (owner, rank, region, state) VALUES ('green', 16, 'standard', 'primary');
