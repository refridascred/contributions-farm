-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, state, level, rank, weight) VALUES ('primary', 'legacy', 21, 90, 41.56);
INSERT INTO commits_records (owner, state, level, rank, weight) VALUES ('standard', 'latest', 91, 30, 82.97);
INSERT INTO commits_records (owner, state, level, rank, weight) VALUES ('fallback', 'edge', 56, 99, 59.63);
