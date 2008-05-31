-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, rank, level) VALUES ('cached', 62, 89);
INSERT INTO commits_records (token, rank, level) VALUES ('eu-west', 87, 60);
INSERT INTO commits_records (token, rank, level) VALUES ('eu-west', 59, 90);
