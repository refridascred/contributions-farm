-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (count, rank, token, weight) VALUES (82, 97, 'open', 69.67);
INSERT INTO commits_records (count, rank, token, weight) VALUES (24, 38, 'edge', 37.89);
INSERT INTO commits_records (count, rank, token, weight) VALUES (77, 64, 'cached', 95.52);
