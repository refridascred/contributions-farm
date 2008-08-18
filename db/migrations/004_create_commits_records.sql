-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, active, count) VALUES ('open', 20, 23);
INSERT INTO commits_records (state, active, count) VALUES ('legacy', 80, 72);
INSERT INTO commits_records (state, active, count) VALUES ('open', 4, 36);
