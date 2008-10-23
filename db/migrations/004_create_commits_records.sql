-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, region, token, owner) VALUES ('cached', 'eu-west', 'stable', 'local');
INSERT INTO commits_records (state, region, token, owner) VALUES ('primary', 'green', 'standard', 'edge');
