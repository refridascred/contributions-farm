-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, weight, token, level) VALUES (68, 18.06, 'open', 28);
INSERT INTO commits_records (rank, weight, token, level) VALUES (21, 68.48, 'fallback', 84);
