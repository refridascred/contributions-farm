-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, ratio, level, owner) VALUES ('local', 47.29, 20, 'latest');
INSERT INTO commits_records (state, ratio, level, owner) VALUES ('stable', 95.69, 72, 'green');
