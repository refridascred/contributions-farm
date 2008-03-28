-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, count, state, ratio, token) VALUES ('open', 53, 'legacy', 40.71, 'latest');
INSERT INTO layout_items (owner, count, state, ratio, token) VALUES ('staging', 91, 'green', 69.58, 'blue');
