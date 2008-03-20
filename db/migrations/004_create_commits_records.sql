-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, rank, state, owner, ratio) VALUES ('cached', 13, 'cached', 'standard', 45.77);
INSERT INTO commits_records (token, rank, state, owner, ratio) VALUES ('strict', 85, 'edge', 'open', 69.28);
INSERT INTO commits_records (token, rank, state, owner, ratio) VALUES ('latest', 17, 'edge', 'edge', 50.57);
