-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, state, owner, ratio) VALUES ('cached', 'stable', 'primary', 76.97);
INSERT INTO commits_records (label, state, owner, ratio) VALUES ('strict', 'blue', 'strict', 61.43);
