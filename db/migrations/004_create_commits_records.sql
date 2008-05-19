-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, state, region, rank) VALUES (84, 'local', 'legacy', 81);
INSERT INTO commits_records (level, state, region, rank) VALUES (91, 'green', 'green', 14);
