-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, owner, state, level, rank) VALUES (86, 'green', 'cached', 60, 26);
INSERT INTO commits_records (count, owner, state, level, rank) VALUES (58, 'local', 'cached', 92, 34);
INSERT INTO commits_records (count, owner, state, level, rank) VALUES (71, 'cached', 'legacy', 63, 56);
