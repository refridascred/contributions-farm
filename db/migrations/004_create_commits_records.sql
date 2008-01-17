-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (state, rank, ratio) VALUES ('local', 97, 37.61);
INSERT INTO commits_records (state, rank, ratio) VALUES ('eu-west', 73, 68.15);
INSERT INTO commits_records (state, rank, ratio) VALUES ('standard', 1, 67.64);
