-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, count) VALUES ('strict', 'open', 23);
INSERT INTO layout_items (label, state, count) VALUES ('green', 'blue', 86);
INSERT INTO layout_items (label, state, count) VALUES ('eu-west', 'open', 10);
