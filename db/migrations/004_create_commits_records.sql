-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state, active, region, rank) VALUES ('strict', 'stable', 51, 'legacy', 8);
INSERT INTO commits_records (owner, state, active, region, rank) VALUES ('fallback', 'blue', 87, 'strict', 53);
