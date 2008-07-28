-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (level, token, rank) VALUES (87, 'blue', 48);
INSERT INTO commits_records (level, token, rank) VALUES (42, 'standard', 3);
INSERT INTO commits_records (level, token, rank) VALUES (55, 'cached', 8);
