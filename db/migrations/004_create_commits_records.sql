-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, state, level, owner) VALUES ('latest', 'cached', 23, 'fallback');
INSERT INTO commits_records (region, state, level, owner) VALUES ('fallback', 'open', 8, 'cached');
