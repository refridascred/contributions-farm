-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, ratio, state, owner, token) VALUES ('staging', 62.21, 'edge', 'open', 'strict');
INSERT INTO layout_items (region, ratio, state, owner, token) VALUES ('open', 2.81, 'latest', 'standard', 'blue');
