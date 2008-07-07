-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, rank, owner, state) VALUES (86.34, 93, 'blue', 'standard');
INSERT INTO commits_records (ratio, rank, owner, state) VALUES (98.62, 43, 'primary', 'eu-west');
