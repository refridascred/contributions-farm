-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, level, rank) VALUES ('latest', 85, 67);
INSERT INTO commits_records (token, level, rank) VALUES ('strict', 85, 50);
INSERT INTO commits_records (token, level, rank) VALUES ('strict', 70, 21);
