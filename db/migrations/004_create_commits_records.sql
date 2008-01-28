-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, region, count, state, active) VALUES ('strict', 'standard', 1, 'primary', 27);
INSERT INTO commits_records (owner, region, count, state, active) VALUES ('edge', 'latest', 98, 'green', 52);
INSERT INTO commits_records (owner, region, count, state, active) VALUES ('cached', 'standard', 77, 'strict', 14);
