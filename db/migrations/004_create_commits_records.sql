-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, owner, state, ratio) VALUES (61, 'stable', 'edge', 14.46);
INSERT INTO commits_records (level, owner, state, ratio) VALUES (93, 'green', 'fallback', 61.67);
