-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, region, state, rank) VALUES (53, 'legacy', 'eu-west', 64);
INSERT INTO commits_records (count, region, state, rank) VALUES (80, 'primary', 'eu-west', 22);
