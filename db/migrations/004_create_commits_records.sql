-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, owner, region) VALUES ('blue', 'local', 'open');
INSERT INTO commits_records (state, owner, region) VALUES ('cached', 'strict', 'fallback');
INSERT INTO commits_records (state, owner, region) VALUES ('stable', 'primary', 'stable');
