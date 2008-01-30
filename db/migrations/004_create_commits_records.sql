-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, owner) VALUES ('open', 'fallback', 'edge');
INSERT INTO commits_records (state, region, owner) VALUES ('local', 'blue', 'strict');
INSERT INTO commits_records (state, region, owner) VALUES ('eu-west', 'strict', 'stable');
