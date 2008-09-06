-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, state, count, owner, ratio) VALUES ('primary', 'cached', 84, 'local', 18.55);
INSERT INTO commits_records (region, state, count, owner, ratio) VALUES ('latest', 'edge', 61, 'blue', 75.12);
