-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, rank, weight, active, state) VALUES ('stable', 19, 16.33, 67, 'green');
INSERT INTO commits_records (owner, rank, weight, active, state) VALUES ('latest', 5, 67.24, 28, 'stable');
