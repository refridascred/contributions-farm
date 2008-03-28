-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, rank) VALUES (79, 73);
INSERT INTO commits_records (level, rank) VALUES (69, 26);
INSERT INTO commits_records (level, rank) VALUES (42, 34);
