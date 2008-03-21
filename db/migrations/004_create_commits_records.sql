-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight) VALUES ('green', 15.52);
INSERT INTO commits_records (state, weight) VALUES ('open', 56.93);
INSERT INTO commits_records (state, weight) VALUES ('strict', 69.07);
