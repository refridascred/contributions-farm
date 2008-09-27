-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, ratio, owner, rank, state) VALUES (11, 19.82, 'local', 2, 'local');
INSERT INTO commits_records (level, ratio, owner, rank, state) VALUES (86, 25.23, 'cached', 76, 'local');
