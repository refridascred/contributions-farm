-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, owner, token) VALUES ('latest', 'stable', 'cached');
INSERT INTO layout_items (label, owner, token) VALUES ('latest', 'standard', 'strict');
