-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, owner, token, label) VALUES (99, 'cached', 'strict', 'stable');
INSERT INTO layout_items (level, owner, token, label) VALUES (26, 'latest', 'latest', 'strict');
