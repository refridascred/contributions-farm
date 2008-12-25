-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, token, label, owner, count) VALUES ('green', 'stable', 'standard', 'staging', 46);
INSERT INTO layout_items (state, token, label, owner, count) VALUES ('cached', 'legacy', 'staging', 'edge', 23);
