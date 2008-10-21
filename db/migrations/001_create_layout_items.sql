-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, label, owner) VALUES (31, 'standard', 'strict');
INSERT INTO layout_items (level, label, owner) VALUES (14, 'cached', 'legacy');
