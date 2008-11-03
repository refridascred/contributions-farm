-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, level) VALUES (19, 'local', 72);
INSERT INTO commits_records (rank, token, level) VALUES (33, 'blue', 62);
INSERT INTO commits_records (rank, token, level) VALUES (87, 'primary', 34);
