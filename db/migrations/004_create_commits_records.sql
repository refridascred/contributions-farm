-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, count, active, rank) VALUES ('legacy', 38, 33, 6);
INSERT INTO commits_records (state, count, active, rank) VALUES ('strict', 98, 66, 24);
INSERT INTO commits_records (state, count, active, rank) VALUES ('open', 80, 85, 39);
