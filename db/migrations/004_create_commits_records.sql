-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight, rank, state) VALUES (13, 89.84, 28, 'blue');
INSERT INTO commits_records (level, weight, rank, state) VALUES (0, 7.14, 5, 'staging');
