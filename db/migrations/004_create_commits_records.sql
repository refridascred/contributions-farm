-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, owner, level) VALUES (17, 'cached', 51);
INSERT INTO commits_records (rank, owner, level) VALUES (68, 'staging', 79);
INSERT INTO commits_records (rank, owner, level) VALUES (75, 'standard', 63);
