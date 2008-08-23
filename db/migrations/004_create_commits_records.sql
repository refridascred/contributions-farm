-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, ratio, owner, state) VALUES ('legacy', 49.67, 'strict', 'blue');
INSERT INTO commits_records (token, ratio, owner, state) VALUES ('stable', 58.68, 'open', 'legacy');
INSERT INTO commits_records (token, ratio, owner, state) VALUES ('cached', 12.25, 'green', 'fallback');
