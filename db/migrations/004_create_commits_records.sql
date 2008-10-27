-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, state, token, region) VALUES ('strict', 'local', 'open', 'standard');
INSERT INTO commits_records (label, state, token, region) VALUES ('green', 'latest', 'blue', 'blue');
INSERT INTO commits_records (label, state, token, region) VALUES ('strict', 'local', 'latest', 'cached');
