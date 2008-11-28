-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, owner) VALUES ('open', 'latest', 'blue');
INSERT INTO layout_items (label, token, owner) VALUES ('local', 'cached', 'strict');
