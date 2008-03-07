-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, state, label) VALUES (30, 'legacy', 'local');
INSERT INTO layout_items (count, state, label) VALUES (89, 'stable', 'standard');
INSERT INTO layout_items (count, state, label) VALUES (6, 'eu-west', 'stable');
