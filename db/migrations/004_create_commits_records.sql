-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, rank, state) VALUES ('eu-west', 8, 'fallback');
INSERT INTO commits_records (label, rank, state) VALUES ('latest', 20, 'strict');
INSERT INTO commits_records (label, rank, state) VALUES ('staging', 51, 'eu-west');
