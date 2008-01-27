-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, rank, active, owner, label) VALUES (7.41, 20, 53, 'staging', 'stable');
INSERT INTO layout_items (score, rank, active, owner, label) VALUES (44.57, 23, 66, 'local', 'strict');
