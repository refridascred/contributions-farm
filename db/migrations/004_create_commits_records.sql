-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (state, owner, label, region) VALUES ('blue', 'green', 'cached', 'strict');
INSERT INTO commits_records (state, owner, label, region) VALUES ('latest', 'eu-west', 'cached', 'blue');
