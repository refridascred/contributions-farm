-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, state, count, level) VALUES ('latest', 'primary', 57, 87);
INSERT INTO commits_records (label, state, count, level) VALUES ('staging', 'eu-west', 12, 74);
INSERT INTO commits_records (label, state, count, level) VALUES ('open', 'stable', 28, 97);
