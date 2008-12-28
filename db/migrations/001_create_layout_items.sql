-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, token, owner, label) VALUES (21, 'legacy', 'edge', 'open');
INSERT INTO layout_items (count, token, owner, label) VALUES (99, 'standard', 'stable', 'stable');
