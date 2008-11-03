-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, token, rank) VALUES ('latest', 'open', 17);
INSERT INTO commits_records (state, token, rank) VALUES ('blue', 'local', 96);
INSERT INTO commits_records (state, token, rank) VALUES ('strict', 'open', 94);
