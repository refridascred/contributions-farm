-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (score, owner, token) VALUES (3.83, 'open', 'open');
INSERT INTO layout_items (score, owner, token) VALUES (93.25, 'strict', 'stable');
INSERT INTO layout_items (score, owner, token) VALUES (56.35, 'green', 'primary');
